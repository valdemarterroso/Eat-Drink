using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EatDrink.Models
{
    public class Cliente
    {
        [Key]
        public int idCliente { get; set; }
        [Key]
        public int idUser { get; set; }

        public Cliente()
        {

        }
    }
}
