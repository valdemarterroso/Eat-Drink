using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eatdrink.Models;

namespace Eatdrink.Utils
{
    public class DbHelper : DbContext
    {
        public DbHelper()
        {
        }

        public DbSet<Administrador> administrador { get; set; }
        public DbSet<Cliente> cliente { get; set; }
        public DbSet<Empresa> empresa { get; set; }
        public DbSet<Condutor> condutor { get; set; }
        public DbSet<Encomenda> encomenda { get; set; }
        public DbSet<EncomendarProduto> EncomendarProduto { get; set; }
        public DbSet<Entrega> entrega { get; set; }
        public DbSet<Produto> produto { get; set; }
        public DbSet<Utilizador> utilizador { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source= db/eatdrink.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Utilizador>().HasKey(u => new { u.UtilizadorId });
            modelBuilder.Entity<Administrador>().HasKey(a => new { a.UtilizadorId });
            modelBuilder.Entity<Cliente>().HasKey(cl => new { cl.UtilizadorId });
            modelBuilder.Entity<Condutor>().HasKey(c => new { c.UtilizadorId });
            modelBuilder.Entity<Empresa>().HasKey(em => new { em.UtilizadorId, em.EmpresaId });
            modelBuilder.Entity<Encomenda>().HasKey(e => new { e.ClienteId, e.EncomendarProdutoId });
            modelBuilder.Entity<EncomendarProduto>().HasKey(ep => new { ep.ProdutoId });
            modelBuilder.Entity<Entrega>().HasKey(ent => new { ent.CondutorId, ent.EncomendaId });
            modelBuilder.Entity<Produto>().HasKey(p => new { p.EmpresaId });
        }
    }
}
