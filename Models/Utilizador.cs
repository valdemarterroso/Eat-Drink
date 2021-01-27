using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eatdrink.Models
{
    public class Utilizador
    {
        [Key]
        public int UtilizadorId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Telefone { get; set; }
        public int CodigoPostal { get; set; }
        public string Localidade { get; set; }
        public string Nacionalidade { get; set; }
        public int DataNascimento { get; set; }
        public string NomeRua { get; set; }
        public int NumeroPorta { get; set; }
        public string tipoUtilizador { get; set; }

        public Utilizador()
        {
        }
    }
}
