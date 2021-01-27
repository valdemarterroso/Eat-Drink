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
    public class EntregaController : ControllerBase
    {
        // GET: api/<EntregaController>
        [HttpGet]
        public Entrega[] Get()
        {
            using (var db = new DbHelper())
            {
                return db.entrega.ToArray();
            }

            //HttpContext.Response.StatusCode = (int)

            //return null;
        }

        // GET api/<EntregaController>/5
        [HttpGet("{id}")]
        public Entrega Get(int id)
        {

            using (var db = new DbHelper())
            {
                var entregaDB = db.entrega.ToArray();

                for (int i = 0; i <= entregaDB.Length; i++)
                {

                    if (entregaDB[i].EntregaId == id)
                    {
                        return entregaDB[i];
                    }
                }

                return null;
            }
        }

        // POST api/<EntregaController>
        [HttpPost]
        public string Post([FromBody] Entrega novaEntrega)
        {
            using (var db = new DbHelper())
            {
                var entregaDB = db.entrega.ToArray();

                for (int i = 0; i < entregaDB.Length; i++)
                {

                    if (novaEntrega.EntregaId == entregaDB[i].EntregaId)
                    {
                        return "Já existe";
                    }
                }

                db.entrega.Add(novaEntrega);
                db.SaveChanges();

                return "Criado";
            }
        }

        // PUT api/<EntregaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Entrega entregaUpdate)
        {
            using (var db = new DbHelper())
            {
                var entregaDB = db.entrega.Find(id);

                if (entregaDB == null)
                {
                    Post(entregaUpdate);
                }
                else
                {
                    entregaDB.EntregaId = id;

                    db.entrega.Update(entregaDB);
                    db.SaveChanges();
                }
            }
        }

        // DELETE api/<EntregaController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            using (var db = new DbHelper())
            {
                var entregaDB = db.entrega.Find(id);

                if (entregaDB != null)
                {
                    db.entrega.Remove(entregaDB);
                    db.SaveChanges();

                    return "Eliminado!";
                }
                else
                {
                    return "A entrega com o id: " + id + " não foi encontrada";
                }
            }
        }
    }
}
