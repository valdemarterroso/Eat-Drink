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
    public class EmpresaController : ControllerBase
    {
        // GET: api/<EmpresaController>
        [HttpGet]
        public Empresa[] Get()
        {
            using (var db = new DbHelper())
            {
                return db.empresa.ToArray();
            }

            //HttpContext.Response.StatusCode = (int)

            //return null;
        }

        // GET api/<EmpresaController>/5
        [HttpGet("{id}")]
        public Empresa Get(int id)
        {

            using (var db = new DbHelper())
            {
                var empresa = db.empresa.ToArray();

                for (int i = 0; i <= empresa.Length; i++)
                {

                    if (empresa[i].EmpresaId == id)
                    {
                        return empresa[i];
                    }
                }

                return null;
            }
        }


        // POST api/<EmpresaController>
        [HttpPost]
        public string Post([FromBody] Empresa novaEmpresa)
        {
            using (var db = new DbHelper())
            {
                var empresa = db.empresa.ToArray();

                for (int i = 0; i < empresa.Length; i++)
                {

                    if (novaEmpresa.EmpresaId == empresa[i].EmpresaId)
                    {
                        return "Já existe";
                    }
                }

                db.empresa.Add(novaEmpresa);
                db.SaveChanges();

                return "Criado";
            }
        }


        // PUT api/<EmpresaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Empresa empresaUpdate)
        {
            using (var db = new DbHelper())
            {
                var empresaDB = db.empresa.Find(id);

                if (empresaDB == null)
                {
                    Post(empresaUpdate);
                }
                else
                {
                    empresaDB.EmpresaId = id;

                    db.empresa.Update(empresaDB);
                    db.SaveChanges();
                }
            }
        }

        // DELETE api/<EmpresaController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            using (var db = new DbHelper())
            {
                var empresaDB = db.empresa.Find(id);

                if (empresaDB != null)
                {
                    db.empresa.Remove(empresaDB);
                    db.SaveChanges();

                    return "Eliminado!";
                }
                else
                {
                    return "O Empresa com o id: " + id + " não foi encontrado";
                }
            }
        }

        //validar encomenda

        //atualizar encomenda
    }
}
