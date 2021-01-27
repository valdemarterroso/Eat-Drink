using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eatdrink.Models
{
    public class Entrega
    {
        [Key]
        public int EntregaId { get; set; }
        [Key]
        public int CondutorId { get; set; }
        [Key]
        public int EncomendaId { get; set; }
        public string Estado { get; set; }

        public Entrega()
        {
        }
    }
}
