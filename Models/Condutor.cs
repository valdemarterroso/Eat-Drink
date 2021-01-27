using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Eatdrink.Models
{
    public class Condutor
    {
        [Key]
        public int CondutorId { get; set; }
        [Key]
        public int UtilizadorId { get; set; }
        public int NumeroCartaConducao { get; set; }
        public string TipoVeiculo { get; set; }

        public Condutor()
        {
        }
    }
}
