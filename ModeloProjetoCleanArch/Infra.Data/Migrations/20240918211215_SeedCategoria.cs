using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var id = Guid.NewGuid().ToString();
            var data = DateTimeOffset.Now.ToString("MM/dd/yyyy HH:mm:ss");
            var nome = "Passeio";
            migrationBuilder.Sql($"INSERT INTO Categoria(Id, Nome, DataCriacao) VALUES ('{id}', '{nome}', '{data}');");


            id = Guid.NewGuid().ToString();
            nome = "Esportivo";
            migrationBuilder.Sql($"INSERT INTO Categoria(Id, Nome, DataCriacao) VALUES ('{id}', '{nome}', '{data}');");


            id = Guid.NewGuid().ToString();
            nome = "Utilitário";
            migrationBuilder.Sql($"INSERT INTO Categoria(Id, Nome, DataCriacao) VALUES ('{id}', '{nome}', '{data}');");


            id = Guid.NewGuid().ToString();
            nome = "Escolar";
            migrationBuilder.Sql($"INSERT INTO Categoria(Id, Nome, DataCriacao) VALUES ('{id}', '{nome}', '{data}');");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categoria");
        }
    }
}
