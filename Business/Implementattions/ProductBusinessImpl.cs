using System.Collections.Generic;
using LojaVirtual.Data.Converters;
using LojaVirtual.Data.VO;
using LojaVirtual.Repository.Generic;
using System.IO;

namespace LojaVirtual.Business.Implementations
{
    public class ProductBusinessImpl : IProductBusiness
    {
        private IProductRepository _repository;
        private readonly ProductConverter _converter;

        public ProductBusinessImpl(IProductRepository repository)
        {
            _repository = repository;
            _converter = new ProductConverter();
        }

        public ProductVO Create(ProductVO product)
        {
            var productEntity = _converter.Parse(product);
            productEntity = _repository.Create(productEntity);
            SaveFile(productEntity.Image, productEntity.Id);

            return _converter.Parse(productEntity);
        }

        public void SaveFile(byte[] bytes, long? fileId) {
            File.WriteAllBytes(@"/home/vitor777/Desktop/loja_virtual/produtos_imagem/" + fileId + ".png", bytes);
        }

        public void Delete(long id)
        {
          
        }

        public List<ProductVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public ProductVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public ProductVO Update(ProductVO book)
        {
            return null;
        }
    }
}
