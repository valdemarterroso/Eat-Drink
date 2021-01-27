using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eatdrink.Models
{
    public class Encomenda
    {
        [Key]
        public int EncomendaId { get; set; }
        [Key]
        public int ClienteId { get; set; }
        [Key]
        public int EncomendarProdutoId { get; set; }

        public Encomenda()
        {
        }
    }
}
