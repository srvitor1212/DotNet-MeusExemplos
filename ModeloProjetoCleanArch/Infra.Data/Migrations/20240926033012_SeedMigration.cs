using Domain.Model.UmPraUm;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //todo: da pra fazer bem mais top essa migration

            #region Dados compartilhados

            var data1 = new DateTimeOffset(2024, 01, 28, 22, 45, 48, TimeSpan.Zero).ToString("MM/dd/yyyy hh:mm:ss");
            var data2 = new DateTimeOffset(2024, 08, 14, 14, 00, 32, TimeSpan.Zero).ToString("MM/dd/yyyy hh:mm:ss");
            var data3 = new DateTimeOffset(2024, 11, 04, 08, 22, 47, TimeSpan.Zero).ToString("MM/dd/yyyy hh:mm:ss");



            var audi = new
            {
                id = "2D2D4B8F-CCF2-45FB-999D-FD23431299E4",
                nome = "Audi",
                cnpj = "01.123.456/0001-77",
                criacao = data1
            };
            var audi1 = new { id = "818FC085-9727-40D4-BA36-3493C6F7A082", criacao = data1, modelo = "Audi A3" };
            var audi2 = new { id = "FB76A33F-6C16-4AEB-B066-F18DBEF7AA7F", criacao = data2, modelo = "Audi A5 Sportback" };



            var bmw = new
            {
                id = "7D217484-F244-49D9-A576-AC6297D63E36",
                nome = "BMW",
                cnpj = "02.123.456/0001-77",
                criacao = data2
            };
            var bmw1 = new { id = "B59EF2E6-A828-4CD1-9D03-68A30659A43B", criacao = data1, modelo = "BMW i3" };
            var bmw2 = new { id = "DFC34AA3-596A-426A-8179-EC3558A33F19", criacao = data3, modelo = "BMW M1" };
            var bmw3 = new { id = "DCBA544C-4EF1-44DE-BA64-F75C4BD3D00B", criacao = data1, modelo = "BMW X7" };



            var ford = new
            {
                id = "F8393A20-43FD-45D5-A671-FF2D7280FCE8",
                nome = "FORD",
                cnpj = "03.123.456/0001-77",
                criacao = data3
            };
            var ford1 = new { id = "24059075-756E-447C-9AC7-8108FAFACBC3", criacao = data3, modelo = "Ford F-150" };
            var ford2 = new { id = "43B769BE-6378-4880-A3E3-2DD39A3B3C96", criacao = data2, modelo = "Ford Ranger" };

            #endregion

            #region Fabricantes


            migrationBuilder.Sql($"INSERT INTO Fabricante(Id, DataCriacao, Nome, CNPJ) " +
                                 $"VALUES ('{audi.id}', '{audi.criacao}', '{audi.nome}', '{audi.cnpj}');");

            migrationBuilder.Sql($"INSERT INTO Fabricante(Id, DataCriacao, Nome, CNPJ) " +
                                 $"VALUES ('{bmw.id}', '{bmw.criacao}', '{bmw.nome}', '{bmw.cnpj}');");

            migrationBuilder.Sql($"INSERT INTO Fabricante(Id, DataCriacao, Nome, CNPJ) " +
                                 $"VALUES ('{ford.id}', '{ford.criacao}', '{ford.nome}', '{ford.cnpj}');");


            #endregion

            #region Carros


            // audi
            migrationBuilder.Sql($"INSERT INTO Carro(Id, DataCriacao, Modelo, FabricanteId) " +
                                 $"VALUES ('{audi1.id}', '{audi1.criacao}', '{audi1.modelo}', '{audi.id}');");

            migrationBuilder.Sql($"INSERT INTO Carro(Id, DataCriacao, Modelo, FabricanteId) " +
                                 $"VALUES ('{audi2.id}', '{audi2.criacao}', '{audi2.modelo}', '{audi.id}');");


            // bmw
            migrationBuilder.Sql($"INSERT INTO Carro(Id, DataCriacao, Modelo, FabricanteId) " +
                                 $"VALUES ('{bmw1.id}', '{bmw1.criacao}', '{bmw1.modelo}', '{bmw.id}');");

            migrationBuilder.Sql($"INSERT INTO Carro(Id, DataCriacao, Modelo, FabricanteId) " +
                                 $"VALUES ('{bmw2.id}', '{bmw2.criacao}', '{bmw2.modelo}', '{bmw.id}');");

            migrationBuilder.Sql($"INSERT INTO Carro(Id, DataCriacao, Modelo, FabricanteId) " +
                                 $"VALUES ('{bmw3.id}', '{bmw3.criacao}', '{bmw3.modelo}', '{bmw.id}');");


            //ford
            migrationBuilder.Sql($"INSERT INTO Carro(Id, DataCriacao, Modelo, FabricanteId) " +
                                 $"VALUES ('{ford1.id}', '{ford1.criacao}', '{ford1.modelo}', '{ford.id}');");

            migrationBuilder.Sql($"INSERT INTO Carro(Id, DataCriacao, Modelo, FabricanteId) " +
                                 $"VALUES ('{ford2.id}', '{ford2.criacao}', '{ford2.modelo}', '{ford.id}');");



            #endregion

            #region Chassi


            // audi
            migrationBuilder.Sql($"INSERT INTO Chassi(Id, DataCriacao, NumeroDeSerie, CarroId) " +
                                 $"VALUES ('{Guid.NewGuid().ToString()}', '{data1}', '123456', '{audi1.id}');");

            migrationBuilder.Sql($"INSERT INTO Chassi(Id, DataCriacao, NumeroDeSerie, CarroId) " +
                                 $"VALUES ('{Guid.NewGuid().ToString()}', '{data1}', '234567', '{audi2.id}');");


            // bmw
            migrationBuilder.Sql($"INSERT INTO Chassi(Id, DataCriacao, NumeroDeSerie, CarroId) " +
                                 $"VALUES ('{Guid.NewGuid().ToString()}', '{data1}', '345678', '{bmw1.id}');");

            migrationBuilder.Sql($"INSERT INTO Chassi(Id, DataCriacao, NumeroDeSerie, CarroId) " +
                                 $"VALUES ('{Guid.NewGuid().ToString()}', '{data1}', '456789', '{bmw2.id}');");

            migrationBuilder.Sql($"INSERT INTO Chassi(Id, DataCriacao, NumeroDeSerie, CarroId) " +
                                 $"VALUES ('{Guid.NewGuid().ToString()}', '{data1}', '567890', '{bmw3.id}');");


            // ford
            migrationBuilder.Sql($"INSERT INTO Chassi(Id, DataCriacao, NumeroDeSerie, CarroId) " +
                                 $"VALUES ('{Guid.NewGuid().ToString()}', '{data1}', '741852', '{ford1.id}');");

            migrationBuilder.Sql($"INSERT INTO Chassi(Id, DataCriacao, NumeroDeSerie, CarroId) " +
                                 $"VALUES ('{Guid.NewGuid().ToString()}', '{data1}', '415263', '{ford2.id}');");



            #endregion

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }

    }
}
