﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EatDrink.Models;
using EatDrink.Utils;

namespace EatDrink.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class EmpresasController : ControllerBase
    {
        // GET: api/<EmpresasController>
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

        // GET api/<EmpresasController>/5
        [HttpGet("{id}")]
        public Empresa Get(int id)
        {
            using (var db = new DbHelper())
            {
                var empresa = db.empresa.ToArray();

                for (int i = 0; i <= empresa.Length; i++)
                {

                    if (empresa[i].idEmpresa == id)
                    {
                        return empresa[i];
                    }
                }

                return null;
            }
        }

        //ou

        /*
         public Empresa Get(int id)
        {
            using (var db = new DbHelper())
            {
                return db.empresa.Find(id);
            }
        }
         */

        // POST api/<EmpresasController>
        //[HttpPost]
        //public string Post([FromBody] Empresa novaEmpresa)
        //{

        //}
        // ou

        /*
        [HttpPost]
        public string Post([FromBody] Empresa novaEmpresa)
        {
            using (var db = new DbHelper())
            {
                cavalo.cod_cavaço = new Random().Next();
                db.empresa.Add(novaEmpresa);
                db.SaveChanges();
            }
        }
         */
    }
}
