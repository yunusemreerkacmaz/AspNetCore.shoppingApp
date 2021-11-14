using Microsoft.EntityFrameworkCore;
using ShoppingApp.MsSqlServer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.MsSqlServer.DataAccess.Concrete.EntityFramework
{
   public class MsSqlServerContext :DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;database=MsSqlServer; Trusted_Connection=True");
        }

      
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
