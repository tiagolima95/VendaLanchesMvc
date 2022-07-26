using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto_AspNetCore_Mvc.Migrations
{
    public partial class PopularTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao)" +
                "VALUES('Lanches Normais','Lanches feitos com ingredientes normais')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao)" +
                "VALUES('Lanches Naturais','Lanches feitos com ingredientes integrais e naturais')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
