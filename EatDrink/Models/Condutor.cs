using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EatDrink.Models
{
    public class Condutor
    {
        [Key]
        public int idCondutor { get; set; }
        [Key]
        public int idUser { get; set; }
        public string numeroCartaConducao { get; set; }
        public string tipoDeVeiculo { get; set; }

        public Condutor()
        {

        }
    }
}
