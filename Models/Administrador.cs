using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Eatdrink.Models
{
    public class Administrador
    {
        [Key]
        public int AdministradorId { get; set; }
        [Key]
        public int UtilizadorId { get; set; }

        public Administrador()
        {

        }
    }
}
