using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eatdrink.Models
{
    public class EncomendarProduto
    {
        [Key]
        public int EncomendarProdutoId { get; set; }
        [Key]
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public EncomendarProduto()
        {
        }
    }
}
