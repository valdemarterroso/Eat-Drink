using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eatdrink.Models;
using Eatdrink.Utils;
using Microsoft.AspNetCore.Mvc;

namespace Eatdrink.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class UtilizadorController : ControllerBase
    {
        // GET: api/<UtilizadorController>
        [HttpGet]
        public Utilizador[] Get()
        {
            using (var db = new DbHelper())
            {
                return db.utilizador.ToArray();
            }

            //HttpContext.Response.StatusCode = (int)

            //return null;
        }

        // GET api/<UtilizadorController>/5
        [HttpGet("{id}")]
        public Utilizador Get(int id)
        {

            using (var db = new DbHelper())
            {
                var utilizador = db.utilizador.ToArray();

                for (int i = 0; i <= utilizador.Length; i++)
                {

                    if (utilizador[i].UtilizadorId == id)
                    {
                        return utilizador[i];
                    }
                }

                return null;
            }
        }

        // POST api/<UtilizadorController>
        [HttpPost]
        public string Post([FromBody] Utilizador novoUtilizador)
        {
            using (var db = new DbHelper())
            {
                var utilizador = db.utilizador.ToArray();

                for (int i = 0; i < utilizador.Length; i++)
                {

                    if (novoUtilizador.UtilizadorId == utilizador[i].UtilizadorId)
                    {
                        return "Já existe";
                    }
                }

                db.utilizador.Add(novoUtilizador);
                db.SaveChanges();

                return "Criado";
            }
        }

        // PUT api/<UtilizadorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Utilizador utilizadorUpdate)
        {
            using (var db = new DbHelper())
            {
                var utilizadorDB = db.utilizador.Find(id);

                if (utilizadorDB == null)
                {
                    Post(utilizadorUpdate);
                }
                else
                {
                    utilizadorDB.UtilizadorId = id;

                    if (utilizadorUpdate.Email != null)
                    {
                        utilizadorDB.Email = utilizadorUpdate.Email;
                    }

                    if (utilizadorUpdate.Nome != null)
                    {
                        utilizadorDB.Nome = utilizadorUpdate.Nome;
                    }

                    if (utilizadorUpdate.Password != null)
                    {
                        utilizadorDB.Password = utilizadorUpdate.Password;
                    }

                    db.utilizador.Update(utilizadorDB);
                    db.SaveChanges();
                }
            }
        }

        // DELETE api/<UtilizadorController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            using (var db = new DbHelper())
            {
                var utilizadorDB = db.utilizador.Find(id);

                if (utilizadorDB != null)
                {
                    db.utilizador.Remove(utilizadorDB);
                    db.SaveChanges();

                    return "Eliminado!";
                }
                else
                {
                    return "O Utilizador com o UtilizadorId: " + id + " não foi encontrado";
                }
            }
        }
    }
}