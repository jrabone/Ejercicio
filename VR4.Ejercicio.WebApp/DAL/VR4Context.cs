using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using VR4.Ejercicio.WebApp.Models;

namespace VR4.Ejercicio.WebApp.DAL
{
    public class VR4Context : DbContext
    {
        public VR4Context() : base("DefaultConnection")
        {
        }

        public DbSet<Product> Signals { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}