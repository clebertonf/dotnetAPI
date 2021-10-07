using Microsoft.EntityFrameworkCore.Migrations;

namespace APiEstudo.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { 1, "I5 256 SSD 16GB Ram", "Desktop" });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { 2, "Galaxy M30", "Samsung" });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { 3, "Iphone 13", "Iphone Apple" });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { 4, "Smart 55 polegadas", "smart tv" });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { 5, "Mouse del ergonômico", "Mouse del" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
