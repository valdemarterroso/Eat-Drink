using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EatDrink.Models
{
    public class Encomenda
    {
        [Key]
        public int idEncomenda { get; set; }
        [Key]
        public int idCliente { get; set; }
        [Key]
        public int idEncomendaProduto { get; set; }

        public Encomenda()
        {

        }
    }
}
