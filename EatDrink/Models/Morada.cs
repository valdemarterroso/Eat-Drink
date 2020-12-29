using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EatDrink.Models
{
    public class Morada
    {
        [Key]
        public int idMorada { get; set; }
        public string nomeRua { get; set; }
        public int numeroPorta { get; set; }
        public string andar { get; set; }
        public string codigoPostal { get; set; }
        public string localidade { get; set; }

        public Morada()
        {

        }
    }
}
