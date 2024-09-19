using Domain.Model.UmPraUm;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCarroEChassi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var idCarro = Guid.NewGuid().ToString();
            var idChassi = Guid.NewGuid().ToString();
            var modelo = "";
            var dataAgora = DateTimeOffset.Now.ToString("MM/dd/yyyy hh:mm:ss");


            idCarro = Guid.NewGuid().ToString();
            idChassi = Guid.NewGuid().ToString();
            modelo = "Gol 2004";
            migrationBuilder.Sql($"INSERT INTO Carro(Id, Modelo, DataCriacao) " +
                                 $"VALUES ('{idCarro}', '{modelo}', '{dataAgora}');");
            migrationBuilder.Sql($"INSERT INTO Chassi(Id, NumeroDeSerie, CarroId, DataCriacao) " +
                                 $"VALUES ('{idChassi}' , '123456789', '{idCarro}', '{dataAgora}');");


            idCarro = Guid.NewGuid().ToString();
            idChassi = Guid.NewGuid().ToString();
            modelo = "Punto TSI 2014";
            migrationBuilder.Sql($"INSERT INTO Carro(Id, Modelo, DataCriacao) " +
                                 $"VALUES ('{idCarro}', '{modelo}', '{dataAgora}');");
            migrationBuilder.Sql($"INSERT INTO Chassi(Id, NumeroDeSerie, CarroId, DataCriacao) " +
                                 $"VALUES ('{idChassi}' , '741852963', '{idCarro}', '{dataAgora}');");


            idCarro = Guid.NewGuid().ToString();
            idChassi = Guid.NewGuid().ToString();
            modelo = "Siena Sedan 2022";
            migrationBuilder.Sql($"INSERT INTO Carro(Id, Modelo, DataCriacao) " +
                                 $"VALUES ('{idCarro}', '{modelo}', '{dataAgora}');");
            migrationBuilder.Sql($"INSERT INTO Chassi(Id, NumeroDeSerie, CarroId, DataCriacao) " +
                                 $"VALUES ('{idChassi}' , '987654321', '{idCarro}', '{dataAgora}');");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
