using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using LojaVirtual.Model;
using LojaVirtual.Model.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LojaVirtual.Model
{
    [Table("Carrinho")]
    public class Carrinho : BaseEntity
    {
        public int? Id {get; set;}

        public List<ItemCarrinho> Itens { get; set; }

        public int UserId { get; set; }

        public double Total = 0.0;

        

    }
}