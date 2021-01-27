using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eatdrink.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        [Key]
        public int EmpresaId { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        public Produto()
        {
        }
    }
}