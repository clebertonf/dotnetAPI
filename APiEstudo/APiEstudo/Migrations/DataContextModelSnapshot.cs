// <auto-generated />
using APiEstudo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APiEstudo.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("APiEstudo.Models.Produtos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "I5 256 SSD 16GB Ram",
                            Nome = "Desktop"
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Galaxy M30",
                            Nome = "Samsung"
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Iphone 13",
                            Nome = "Iphone Apple"
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "Smart 55 polegadas",
                            Nome = "smart tv"
                        },
                        new
                        {
                            Id = 5,
                            Descricao = "Mouse del ergonômico",
                            Nome = "Mouse del"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
