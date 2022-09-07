using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.OnlineShoppingCodeFirst.DAL.Models
{
    public class ApplicationDbContext : DbContext
    {
        //Create Table Propery - Map Class to Database Table
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public DbSet<Category> Categories { get; set; }

        //Create Connection String
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=OnlineShopping;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Alter the column
            modelBuilder.Entity<Category>()
                    .Property(c => c.CategoryName)
                    .IsRequired(true)
                    .HasColumnType("varchar(50)");

            //Unqiue Key Constraint using Unique Index
            modelBuilder.Entity<Category>()
                    .HasAlternateKey("CategoryName")
                    .HasName("unq_CategoryName");


            //Applying One to One Relationship
            modelBuilder.Entity<Product>()
                        .HasOne(p => p.Category) //Product as one category
                        .WithOne(c => c.Product) //Category as one Product
                        .HasForeignKey<Product>(p => p.CategoryId);


            modelBuilder.Entity<City>()
                    .HasOne(c => c.CityInformation) //City has one CityInformation
                    .WithOne(ci => ci.City) //CityInformation as one City
                    .HasForeignKey<City>(c => c.CityInformationId);

            //One to Many Relationship
            modelBuilder.Entity<Genre>()
                    .HasOne(g => g.Movie)
                    .WithMany(m => m.Genres);
                    


            //Run add-migration in PMC
            //Run Update-database
        }
    }
}
