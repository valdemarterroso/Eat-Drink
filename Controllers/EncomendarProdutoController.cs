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
    public class EncomendarProdutoController : ControllerBase
    {
        // GET: api/<EncomendarProdutoController>
        [HttpGet]
        public EncomendarProduto[] Get()
        {
            using (var db = new DbHelper())
            {
                return db.EncomendarProduto.ToArray();
            }

            //HttpContext.Response.StatusCode = (int)

            //return null;
        }

        // GET api/<EncomendatProdutoController>/5
        [HttpGet("{id}")]
        public EncomendarProduto Get(int id)
        {

            using (var db = new DbHelper())
            {
                var EncomendarProduto = db.EncomendarProduto.ToArray();

                for (int i = 0; i <= EncomendarProduto.Length; i++)
                {

                    if (EncomendarProduto[i].EncomendarProdutoId == id)
                    {
                        return EncomendarProduto[i];
                    }
                }

                return null;
            }
        }

        // POST api/<EncomendarProdutoController>
        [HttpPost]
        public string Post([FromBody] EncomendarProduto novaEncomendaProduto)
        {
            using (var db = new DbHelper())
            {
                var encomendarProduto = db.EncomendarProduto.ToArray();

                for (int i = 0; i < encomendarProduto.Length; i++)
                {

                    if (novaEncomendaProduto.EncomendarProdutoId == encomendarProduto[i].EncomendarProdutoId)
                    {
                        return "Já existe";
                    }
                }

                db.EncomendarProduto.Add(novaEncomendaProduto);
                db.SaveChanges();

                return "Criado";
            }
        }

        // PUT api/<EncomendarProdutoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] EncomendarProduto encomendarProdutoUpdate)
        {
            using (var db = new DbHelper())
            {
                var encomendarProdutoDB = db.EncomendarProduto.Find(id);

                if (encomendarProdutoDB == null)
                {
                    Post(encomendarProdutoUpdate);
                }
                else
                {
                    encomendarProdutoDB.EncomendarProdutoId = id;

                    db.EncomendarProduto.Update(encomendarProdutoDB);
                    db.SaveChanges();
                }
            }
        }

        // DELETE api/<EncomendarProdutoController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            using (var db = new DbHelper())
            {
                var encomendarProdutoDB = db.EncomendarProduto.Find(id);

                if (encomendarProdutoDB != null)
                {
                    db.EncomendarProduto.Remove(encomendarProdutoDB);
                    db.SaveChanges();

                    return "Eliminado!";
                }
                else
                {
                    return "O encomendarProduto com o id: " + id + " não foi encontrado";
                }
            }
        }
    }
}
