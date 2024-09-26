using Domain.Model.UmPraMuitos;
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
            var data1 = new DateTimeOffset(2024, 01, 28, 22, 45, 48, TimeSpan.Zero).ToString("MM/dd/yyyy hh:mm:ss");
            var data2 = new DateTimeOffset(2024, 08, 14, 14, 00, 32, TimeSpan.Zero).ToString("MM/dd/yyyy hh:mm:ss");
            var data3 = new DateTimeOffset(2024, 11, 04, 08, 22, 47, TimeSpan.Zero).ToString("MM/dd/yyyy hh:mm:ss");

            #region audi

            Random rd = new Random();
            var fabricante = new Fabricante() { Nome = "Audi", CNPJ = "01.546.256/0001-88" };
            var carro = new Carro() { Modelo = "Audi A3", FabricanteId = fabricante.Id };
            var chassi = new Chassi() { NumeroDeSerie = (uint)rd.Next(100000, 999999), CarroId = carro.Id };
            InserirFabricante(migrationBuilder, fabricante, data1);
            InserirCarro(migrationBuilder, carro, data1);
            InserirChassi(migrationBuilder, chassi, data1);

            carro = new Carro() { Modelo = "Audi A5 Sportback", FabricanteId = fabricante.Id };
            chassi = new Chassi() { NumeroDeSerie = (uint)rd.Next(100000, 999999), CarroId = carro.Id };
            InserirCarro(migrationBuilder, carro, data2);
            InserirChassi(migrationBuilder, chassi, data2);

            carro = new Carro() { Modelo = "Audi A4", FabricanteId = fabricante.Id };
            chassi = new Chassi() { NumeroDeSerie = (uint)rd.Next(100000, 999999), CarroId = carro.Id };
            InserirCarro(migrationBuilder, carro, data2);
            InserirChassi(migrationBuilder, chassi, data2);

            carro = new Carro() { Modelo = "Audi A3 Sedan", FabricanteId = fabricante.Id };
            chassi = new Chassi() { NumeroDeSerie = (uint)rd.Next(100000, 999999), CarroId = carro.Id };
            InserirCarro(migrationBuilder, carro, data3);
            InserirChassi(migrationBuilder, chassi, data3);

            #endregion

            #region ford

            fabricante = new Fabricante() { Nome = "FORD", CNPJ = "02.546.256/0001-88" };
            carro = new Carro() { Modelo = "Ford Bronco Sport", FabricanteId = fabricante.Id };
            chassi = new Chassi() { NumeroDeSerie = (uint)rd.Next(100000, 999999), CarroId = carro.Id };
            InserirFabricante(migrationBuilder, fabricante, data1);
            InserirCarro(migrationBuilder, carro, data1);
            InserirChassi(migrationBuilder, chassi, data1);

            carro = new Carro() { Modelo = "Ford F-150", FabricanteId = fabricante.Id };
            chassi = new Chassi() { NumeroDeSerie = (uint)rd.Next(100000, 999999), CarroId = carro.Id };
            InserirCarro(migrationBuilder, carro, data2);
            InserirChassi(migrationBuilder, chassi, data2);

            carro = new Carro() { Modelo = "Ford Maverick", FabricanteId = fabricante.Id };
            chassi = new Chassi() { NumeroDeSerie = (uint)rd.Next(100000, 999999), CarroId = carro.Id };
            InserirCarro(migrationBuilder, carro, data3);
            InserirChassi(migrationBuilder, chassi, data3);

            carro = new Carro() { Modelo = "Ford Ranger", FabricanteId = fabricante.Id };
            chassi = new Chassi() { NumeroDeSerie = (uint)rd.Next(100000, 999999), CarroId = carro.Id };
            InserirCarro(migrationBuilder, carro, data2);
            InserirChassi(migrationBuilder, chassi, data2);

            #endregion


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }

        private void InserirFabricante(MigrationBuilder migrationBuilder, 
            Fabricante obj, string dataCriacao)
        {
            migrationBuilder.Sql(
                $"INSERT INTO Fabricante (Id, DataCriacao, Nome, CNPJ) " +
                $"VALUES ('{obj.Id}', '{dataCriacao}', '{obj.Nome}', '{obj.CNPJ}')" +
                $";");
        }

        private void InserirCarro(MigrationBuilder migrationBuilder, 
            Carro obj, string dataCriacao)
        {
            migrationBuilder.Sql(
                $"INSERT INTO Carro (Id, DataCriacao, Modelo, FabricanteId) " +
                $"VALUES ('{obj.Id}', '{dataCriacao}', '{obj.Modelo}', '{obj.FabricanteId}')" +
                $";");
        }

        private void InserirChassi(MigrationBuilder migrationBuilder, 
            Chassi obj, string dataCriacao)
        {
            migrationBuilder.Sql(
                $"INSERT INTO Chassi (Id, DataCriacao, NumeroDeSerie, CarroId) " +
                $"VALUES ('{obj.Id}', '{dataCriacao}', '{obj.NumeroDeSerie}', '{obj.CarroId}')" +
                $";");
        }
    }
}
