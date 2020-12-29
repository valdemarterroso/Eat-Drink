using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EatDrink.Models
{
    public class User
    {
        [Key]
        public int idUtilizador { get; set; }
        [Key]
        public int idMorada { get; set; }
        public int telemovel { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string dataNascimento { get; set; }

        public User()
        {

        }
    }
}
