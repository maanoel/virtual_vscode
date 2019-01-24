using System;
using System.ComponentModel.DataAnnotations.Schema;
using LojaVirtual.Model;
using LojaVirtual.Model.Base;

namespace LojaVirtual.Model
{
    [Table("ItemCarrinho")]
    public class ItemCarrinho : BaseEntity
    {
        public int Id {get; set;}

        public int ProductId {get; set;}

        public int Quantidade { get; set; }

        public int CarrinhoId {get; set; }
    }
}