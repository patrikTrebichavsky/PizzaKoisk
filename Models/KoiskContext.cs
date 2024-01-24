using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PizzaKiosk.Model
{
    public class KoiskContext : DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<PizzaIngredient> PizzasIngredient { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderedPizza> OrderedPizzas { get; set; }
        public DbSet<OrderedIngredient>OrderedIngredients { get; set; }

        public string DbPath { get; }

        public KoiskContext() 
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DbPath = System.IO.Path.Join(folder, "PizzaContext.db");
        }
        public KoiskContext(string dbName)
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DbPath = DbPath = System.IO.Path.Join(folder, dbName);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (File.Exists(DbPath)) File.Delete(DbPath);
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizza>().HasData( 
                new Pizza() { Id = 1, Name = "Smakulada", Description = "Mnamka", Price = 10000000000, IsAvailable = true, AlergensList = "Vsetky" },
                new Pizza() { Id = 2, Name = "Dobrotka", Description = "Mnaminkaa", Price = 10, IsAvailable = true, AlergensList = "1" }
            );
        }
    }
}
