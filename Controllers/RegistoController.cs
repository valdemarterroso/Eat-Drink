using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Eatdrink.Models;
using Eatdrink.Utils;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using System.IO;


namespace Eatdrink.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class RegistoController : ControllerBase
    {
        // POST api/<RegisterController>
        [HttpPost]
        public string Post([FromBody] Utilizador utilizador)
        {
            using (var db = new DbHelper())
            {
                //vai buscar todos os utilizadores guardados na bd
                //var utilizador = db.utilizador.ToArray();          

                Utilizador utilizadorDB = db.utilizador.FirstOrDefault(Utilizador => Utilizador.Email == Utilizador.Email);
                utilizador.Password = SHA.GenerateSHA512String(utilizador.Password);

                //validar o email
                System.Net.Mail.MailAddress email = new System.Net.Mail.MailAddress(utilizador.Email);

                //verificar tipo de utilizador
                Type cond = typeof(Condutor);
                Type emp = typeof(Empresa);

                //valores aceites para o nome
                var regexNome = new Regex("^[a-zA-Z ]*$");

                //validar a password
                //valida se tem pelo menos um numero
                var numero = new Regex(@"[0-9]+");

                //valida se tem pelo menos uma letra Maiuscula
                var letraMaiuscula = new Regex(@"[A-Z]+");

                if (utilizadorDB == null)
                {
                    db.utilizador.Add(utilizador);
                    db.SaveChanges();
                    return "Registou";
                }
                else
                {
                    return "Nao registou";
                }
            }
        }
    }
}
