using Microsoft.EntityFrameworkCore;
using NPS_PROJECT_API.Models;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;


namespace NPS_PROJECT_API.Data
{
    public class RelacionalClienteContext : DbContext
    {
        public DbSet<RelacionalCliente> RelacionalClientes { get; set; }

        public RelacionalClienteContext(DbContextOptions<RelacionalClienteContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void  OnModelCreating(ModelBuilder Builder)
        {
            base.OnModelCreating(Builder);
        }
         


    }
}
