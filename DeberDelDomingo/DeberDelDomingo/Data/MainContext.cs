using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DeberDelDomingo.Models;

namespace DeberDelDomingo.Data
{
    public class MainContext : DbContext
    {
        public MainContext (DbContextOptions<MainContext> options)
            : base(options)
        {
        }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Celular> Celular { get; set; }
        public DbSet<DeberDelDomingo.Models.Persona> Persona { get; set; }
        
    }
}
