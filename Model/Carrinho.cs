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

        public List <ItemCarrinho> ItensPedido {get;set;}
        public int UserId { get; set; }

        public double Total = 0.0;

        public  double Frete = 0.0;
        
        public String EndBairro{get; set;}

        public String EndRua {get;set;}
        
        public String EndNumero {get;set;}
        
        public String EndCep {get;set;}
        
        public String EndComplemento{get;set;}

        public String EndCidade {get;set;}
        
        public String EndEstado {get;set;}
        
    }
}