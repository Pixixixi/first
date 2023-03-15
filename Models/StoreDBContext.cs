using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    internal class StoreDBContext : DbContext
    {
        public DbSet<Product> Productes { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("Server=(localDB)\\MSSQLLocalDB;Database=StoreDB;integrated security=true");
        }
    }
}
