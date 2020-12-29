using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EatDrink.Models
{
    public class Produto
    {
        [Key]
        public int idProduto { get; set; }
        [Key]
        public int idEmpresa { get; set; }
        public string nome { get; set; }
        public float precoUnitario { get; set; }
        public string ingredientes { get; set; }

        public Produto()
        {

        }
    }
}
