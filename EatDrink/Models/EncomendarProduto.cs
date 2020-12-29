using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EatDrink.Models
{
    public class EncomendarProduto
    {
        [Key]
        public int idEncomendaProduto { get; set; }
        [Key]
        public int idProduto { get; set; }
        public int quantidade { get; set; }

        public EncomendarProduto()
        {

        }
    }
}
