using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eatdrink.Models
{
    public class Empresa
    {
        [Key]
        public int EmpresaId { get; set; }
        [Key]
        public int UtilizadorId { get; set; }
        public int Nif { get; set; }


        public Empresa()
        {

        }
    }
}
