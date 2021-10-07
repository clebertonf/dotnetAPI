using APiEstudo.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

// Faz o mapeamento das classes da pasta models para o Entity criar o banco e as tabelas
namespace APiEstudo.Data
{
    public class DataContext : DbContext
    {
        // colocando no construtor as options do banco de dados recebidas no startup
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Produtos> Produtos { get; set; }

        // Método que popula o banco de dados
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Produtos>()
                .HasData(new List<Produtos>(){
                    new Produtos(1, "Desktop", "I5 256 SSD 16GB Ram"),
                    new Produtos(2, "Samsung", "Galaxy M30"),
                    new Produtos(3, "Iphone Apple", "Iphone 13"),
                    new Produtos(4, "smart tv", "Smart 55 polegadas"),
                    new Produtos(5, "Mouse del", "Mouse del ergonômico"),
                });
        }
    }
}


// Comandos para criar o banco com EntityFrameworkCore

// get-help entityframeworkcore (mostra todos comando possiveis)
// 01 - Add-Migration (cria as migrations)
// 02 - Update-Database (executa as migrations)
