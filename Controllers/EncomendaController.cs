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
    public class EncomendaController : ControllerBase
    {
        // GET: api/<EncomendaController>
        [HttpGet]
        public Encomenda[] Get()
        {
            using (var db = new DbHelper())
            {
                return db.encomenda.ToArray();
            }

            //HttpContext.Response.StatusCode = (int)

            //return null;
        }

        // GET api/<EncomendaController>/5
        [HttpGet("{id}")]
        public Encomenda Get(int id)
        {

            using (var db = new DbHelper())
            {
                var encomendaDB = db.encomenda.ToArray();

                for (int i = 0; i <= encomendaDB.Length; i++)
                {

                    if (encomendaDB[i].EncomendaId == id)
                    {
                        return encomendaDB[i];
                    }
                }

                return null;
            }
        }

        // POST api/<EncomendaController>
        [HttpPost]
        public string Post([FromBody] Encomenda novaEncomenda)
        {
            using (var db = new DbHelper())
            {
                var encomendaDB = db.encomenda.ToArray();

                for (int i = 0; i < encomendaDB.Length; i++)
                {

                    if (novaEncomenda.EncomendaId == encomendaDB[i].EncomendaId)
                    {
                        return "Já existe";
                    }
                }

                db.encomenda.Add(novaEncomenda);
                db.SaveChanges();

                return "Criado";
            }
        }

        // PUT api/<EncomendaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Encomenda encomendaUpdate)
        {
            using (var db = new DbHelper())
            {
                var encomendaDB = db.encomenda.Find(id);

                if (encomendaDB == null)
                {
                    Post(encomendaUpdate);
                }
                else
                {
                    encomendaDB.EncomendaId = id;

                    db.encomenda.Update(encomendaDB);
                    db.SaveChanges();
                }
            }
        }

        // DELETE api/<EncomendaController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            using (var db = new DbHelper())
            {
                var encomendaDB = db.encomenda.Find(id);

                if (encomendaDB != null)
                {
                    db.encomenda.Remove(encomendaDB);
                    db.SaveChanges();

                    return "Eliminado!";
                }
                else
                {
                    return "A encomenda com o id: " + id + " não foi encontrada";
                }
            }
        }

        //listar todas encomendas
    }
}
