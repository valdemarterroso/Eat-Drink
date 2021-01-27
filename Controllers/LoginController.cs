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
    public class LoginController : ControllerBase
    {
        // POST api/<LoginController>
        [HttpPost]
        public Dictionary<string, string> Post([FromBody] Utilizador utilizador)
        {
            using (var db = new DbHelper())
            {
                Utilizador utilizadorDB = db.utilizador.FirstOrDefault(Utilizador => Utilizador.Email == utilizador.Email);
                utilizador.Password = SHA.GenerateSHA512String(utilizador.Password);
                if (utilizadorDB != null)
                {
                    Dictionary<string, string> token = new Dictionary<string, string>
                    {
                        { "Token", TokenManager.GenerateToken(utilizadorDB.Nome)},
                    };

                    return token;
                }
                else
                {
                    Dictionary<string, string> token = new Dictionary<string, string>
                    {
                        { "Token", "Not Found"},
                    };
                    return token;
                }
            }
        }
    }
}
