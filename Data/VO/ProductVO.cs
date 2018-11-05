using System.Collections.Generic;
using Tapioca.HATEOAS;

namespace LojaVirtual.Data.VO
{
    public class ProductVO : ISupportsHyperMedia
    {
        public long? Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public double Peso { get; set; }
        public string Cor { get; set; }
        public string Categoria { get; set; }
        public string Medida { get; set; }
        public int Quantidade { get; set; }
        public string ImageBas64 { get; set; }
        public string ImageUrl { get; set; }

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();

    }
}
