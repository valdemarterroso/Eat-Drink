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
    public class AdministradorController : ControllerBase
    {
        // GET: api/<AdministradorController>
        //Lista
        [HttpGet]
        public Administrador[] Get()
        {
            using (var db = new DbHelper())
            {
                return db.administrador.ToArray();
            }

            //HttpContext.Response.StatusCode = (int)

            //return null;
        }

        // GET api/<AdministradorController>/5
        [HttpGet("{id}")]
        public Administrador Get(int id)
        {

            using (var db = new DbHelper())
            {
                var administrador = db.administrador.ToArray();

                for (int i = 0; i <= administrador.Length; i++)
                {

                    if (administrador[i].AdministradorId == id)
                    {
                        return administrador[i];
                    }
                }

                return null;
            }
        }

        // POST api/<AdministradorController>
        //cria
        [HttpPost]
        public string Post([FromBody] Administrador novoAdministrador)
        {
            using (var db = new DbHelper())
            {
                var administrador = db.administrador.ToArray();

                for (int i = 0; i < administrador.Length; i++)
                {

                    if (novoAdministrador.AdministradorId == administrador[i].AdministradorId)
                    {
                        return "Já existe";
                    }
                }

                db.administrador.Add(novoAdministrador);
                db.SaveChanges();

                return "Criado";
            }
        }

        // PUT api/<AdministradorController>/5
        //atualiza
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Administrador administradorUpdate)
        {
            using (var db = new DbHelper())
            {
                var administradorDB = db.administrador.Find(id);

                if (administradorDB == null)
                {
                    Post(administradorUpdate);
                }
                else
                {
                    administradorDB.AdministradorId = id;

                    db.administrador.Update(administradorDB);
                    db.SaveChanges();
                }
            }
        }

        // DELETE api/<AdministradorController>/5
        //elimina
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            using (var db = new DbHelper())
            {
                var administradorDB = db.administrador.Find(id);

                if (administradorDB != null)
                {
                    db.administrador.Remove(administradorDB);
                    db.SaveChanges();

                    return "Eliminado!";
                }
                else
                {
                    return "O Administrador com o id: " + id + " não foi encontrado";
                }
            }
        }

        //validar utilizador

        //validar produto

    }
}