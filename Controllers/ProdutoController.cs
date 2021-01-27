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
    public class ProdutoController : ControllerBase
    {
        // GET: api/<ProdutoController>
        [HttpGet]
        public Produto[] Get()
        {
            using (var db = new DbHelper())
            {
                return db.produto.ToArray();
            }
        }

        // GET api/<ProdutoController>/5
        [HttpGet("{id}")]
        public Produto Get(int id)
        {

            using (var db = new DbHelper())
            {
                var produtosDB = db.produto.ToArray();

                for (int i = 0; i <= produtosDB.Length; i++)
                {

                    if (produtosDB[i].ProdutoId == id)
                    {
                        return produtosDB[i];
                    }
                }

                return null;
            }
        }

        // POST api/<ProdutoController>
        [HttpPost]
        public string Post([FromBody] Produto novoProduto)
        {
            using (var db = new DbHelper())
            {
                var produtosDB = db.produto.ToArray();

                for (int i = 0; i < produtosDB.Length; i++)
                {

                    if (novoProduto.ProdutoId == produtosDB[i].ProdutoId)
                    {
                        return "Já existe";
                    }
                }

                db.produto.Add(novoProduto);
                db.SaveChanges();

                return "Criado";
            }
        }

        // PUT api/<ProdutoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Produto produtoUpdate)
        {
            using (var db = new DbHelper())
            {
                var produtosDB = db.produto.Find(id);

                if (produtosDB == null)
                {
                    Post(produtoUpdate);
                }
                else
                {
                    produtosDB.ProdutoId = id;

                    db.produto.Update(produtosDB);
                    db.SaveChanges();
                }
            }
        }

        // DELETE api/<ProdutoController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            using (var db = new DbHelper())
            {
                var produtosDB = db.produto.Find(id);

                if (produtosDB != null)
                {
                    db.produto.Remove(produtosDB);
                    db.SaveChanges();

                    return "Eliminado!";
                }
                else
                {
                    return "O produto com o id: " + id + " não foi encontrada";
                }
            }
        }
    }
}
