using System;
using System.Collections.Generic;
using System.Linq;
using LojaVirtual.Data.Converter;
using LojaVirtual.Data.VO;
using LojaVirtual.Model;

namespace LojaVirtual.Data.Converters
{
    public class ProductConverter : IParser<ProductVO, Product>, IParser<Product, ProductVO>
    {
        public Product Parse(ProductVO origin)
        {
            if (origin == null) return new Product();

            return new Product()
            {
                Id = origin.Id,
                Categoria = origin.Categoria,
                Cor = origin.Cor,
                Descricao = origin.Descricao,
                Medida = origin.Medida,
                Peso = origin.Peso,
                Quantidade = origin.Quantidade,
                Valor = origin.Valor,
                Image = Convert.FromBase64String(origin.ImageBas64)
            };

        }

        public ProductVO Parse(Product origin)
        {
            if (origin == null) return new ProductVO();

            return new ProductVO()
            {
                Id = origin.Id,
                Categoria = origin.Categoria,
                Cor = origin.Cor,
                Descricao = origin.Descricao,
                Medida = origin.Medida,
                Peso = origin.Peso,
                Quantidade = origin.Quantidade,
                Valor = origin.Valor,
                ImageBas64 = Convert.ToBase64String(origin.Image)
            };

        }

        public List<Product> ParseList(List<ProductVO> origin)
        {
            if (origin == null) return new List<Product>();
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<ProductVO> ParseList(List<Product> origin)
        {
            if (origin == null) return new List<ProductVO>();
            return origin.Select(item => Parse(item)).ToList();
        }

    }
}
