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
    public class ClienteController : ControllerBase
    {
        // GET: api/<ClienteController>
        [HttpGet]
        public Cliente[] Get()
        {
            using (var db = new DbHelper())
            {
                return db.cliente.ToArray();
            }

            //HttpContext.Response.StatusCode = (int)

            //return null;
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public Cliente Get(int id)
        {

            using (var db = new DbHelper())
            {
                var cliente = db.cliente.ToArray();

                for (int i = 0; i <= cliente.Length; i++)
                {

                    if (cliente[i].ClienteId == id)
                    {
                        return cliente[i];
                    }
                }

                return null;
            }
        }

        // POST api/<ClienteController>
        [HttpPost]
        public string Post([FromBody] Cliente novoCliente)
        {
            using (var db = new DbHelper())
            {
                var cliente = db.cliente.ToArray();

                for (int i = 0; i < cliente.Length; i++)
                {

                    if (novoCliente.ClienteId == cliente[i].ClienteId)
                    {
                        return "Já existe";
                    }
                }

                db.cliente.Add(novoCliente);
                db.SaveChanges();

                return "Criado";
            }
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cliente clienteUpdate)
        {
            using (var db = new DbHelper())
            {
                var clienteDB = db.cliente.Find(id);

                if (clienteDB == null)
                {
                    Post(clienteUpdate);
                }
                else
                {
                    clienteDB.ClienteId = id;

                    db.cliente.Update(clienteDB);
                    db.SaveChanges();
                }
            }
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            using (var db = new DbHelper())
            {
                var clienteDB = db.cliente.Find(id);

                if (clienteDB != null)
                {
                    db.cliente.Remove(clienteDB);
                    db.SaveChanges();

                    return "Eliminado!";
                }
                else
                {
                    return "O Cliente com o id: " + id + " não foi encontrado";
                }
            }
        }

        //ver estado encomenda
    }
}

