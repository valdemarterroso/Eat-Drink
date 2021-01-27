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
    public class CondutorController : ControllerBase
    {
        // GET: api/<CondutorController>
        [HttpGet]
        public Condutor[] Get()
        {
            using (var db = new DbHelper())
            {
                return db.condutor.ToArray();
            }

            //HttpContext.Response.StatusCode = (int)

            //return null;
        }

        // GET api/<CondutorController>/5
        [HttpGet("{id}")]
        public Condutor Get(int id)
        {

            using (var db = new DbHelper())
            {
                var condutor = db.condutor.ToArray();

                for (int i = 0; i <= condutor.Length; i++)
                {

                    if (condutor[i].CondutorId == id)
                    {
                        return condutor[i];
                    }
                }

                return null;
            }
        }


        // POST api/<CondutorController>
        [HttpPost]
        public string Post([FromBody] Condutor novoCondutor)
        {
            using (var db = new DbHelper())
            {
                var condutor = db.condutor.ToArray();

                for (int i = 0; i < condutor.Length; i++)
                {

                    if (novoCondutor.CondutorId == condutor[i].CondutorId)
                    {
                        return "Já existe";
                    }
                }

                db.condutor.Add(novoCondutor);
                db.SaveChanges();

                return "Criado";
            }
        }


        // PUT api/<CondutorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Condutor condutorUpdate)
        {
            using (var db = new DbHelper())
            {
                var condutorDB = db.condutor.Find(id);

                if (condutorDB == null)
                {
                    Post(condutorUpdate);
                }
                else
                {
                    condutorDB.CondutorId = id;

                    db.condutor.Update(condutorDB);
                    db.SaveChanges();
                }
            }
        }

        // DELETE api/<CondutorController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            using (var db = new DbHelper())
            {
                var condutorDB = db.condutor.Find(id);

                if (condutorDB != null)
                {
                    db.condutor.Remove(condutorDB);
                    db.SaveChanges();

                    return "Eliminado!";
                }
                else
                {
                    return "O Condutor com o id: " + id + " não foi encontrado";
                }
            }
        }
    }
}