using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    [Table("pizzas")]
    public class Pizza
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Il nome è obbligatorio")]
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Photo { get; set; }

        public Pizza(string Nome, string Descizione, double Prezzo, string Foto)
        {
            this.Name = Nome;
            this.Description = Descizione;
            this.Price = Prezzo;
            this.Photo = Foto;
        }

        public Pizza()
        { }
    }
    public class PizzaContext : DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = localhost; Initial Catalog = Pizza; Integrated Security = True; Pooling=False");
        }
    }
}
