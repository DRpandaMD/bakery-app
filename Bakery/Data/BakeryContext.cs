using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MySql.Data.EntityFrameworkCore.Extensions;
using Microsoft.Extensions.Configuration;

//additional usinings
using Bakery.Models;
using Bakery.Data.Configurations;

namespace Bakery.Data
{
    public class BakeryContext : DbContext 
    {
        public DbSet<Product> Products { get; set; }

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
           optionsBuilder.UseMySQL("DefaultConnection");
       }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
           modelBuilder.ApplyConfiguration(new ProductConfiguration());
       }
    }
}