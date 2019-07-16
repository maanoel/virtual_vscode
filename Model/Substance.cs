using LojaVirtual.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaVirtual.Model
{
    [Table("substances")]
    public class Substance : BaseEntity
    {
        public string Name { get; set; }
        public string NameScientific { get; set; }
        public string Description { get; set; }
        public string Composto { get; set; }
        public DateTime DataRegistro { get; set; }
        public string Base64Image { get; set; }
        
    }
}
