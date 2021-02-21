using Demo.DataAccess.Concrete.EntityFramework.Mapping;
using Demo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DataAccess.Concrete.EntityFramework.Context
{
    public class DemoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DemoDb;Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new ProductMap());

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Kategori1" },
                new Category { Id = 2, Name = "Kategori2" },
                new Category { Id = 3, Name = "Kategori3" }

                );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Product1", CategoryId = 1 },
                new Product { Id = 2, Name = "Product2", CategoryId = 2 },
                new Product { Id = 3, Name = "Product3", CategoryId = 3 }

                );
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
