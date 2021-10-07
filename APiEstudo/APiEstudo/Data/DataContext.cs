using APiEstudo.Models;
using Microsoft.EntityFrameworkCore;

// Faz o mapeamento das classes da pasta models para o Entity criar o banco e as tabelas
namespace APiEstudo.Data
{
    public class DataContext : DbContext
    {
        // colocando no construtor as options do banco de dados recebidas no startup
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Produtos> Produtos { get; set; }
    }
}
