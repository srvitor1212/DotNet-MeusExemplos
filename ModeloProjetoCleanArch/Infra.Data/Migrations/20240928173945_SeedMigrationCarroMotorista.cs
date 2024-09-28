using Domain.Enum;
using Domain.Model.MuitosPraMuitos;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedMigrationCarroMotorista : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var data1 = new DateTimeOffset(2024, 02, 28, 22, 45, 48, TimeSpan.Zero).ToString("MM/dd/yyyy hh:mm:ss");
            var data2 = new DateTimeOffset(2024, 09, 14, 14, 00, 32, TimeSpan.Zero).ToString("MM/dd/yyyy hh:mm:ss");
            var data3 = new DateTimeOffset(2024, 12, 04, 08, 22, 47, TimeSpan.Zero).ToString("MM/dd/yyyy hh:mm:ss");

            #region Pegar Carros

            var query = $"SELECT * FROM Carro;";
            var carros = migrationBuilder.Sql(query);
            //todo pegar o id dos carros existentes para montar a tabela nova

            #endregion

            #region Motorista

            var motorista = new Motorista()
            {
                Nome = "Adolfo Kristner",
                SituacaoCarteiraMotorista = SituacaoCarteiraMotorista.Ativa,
                TipoCarteira = TipoCarteira.A
            };
            InserirMotorista(migrationBuilder, motorista, data1);

            motorista = new Motorista()
            {
                Nome = "Maria Cristina",
                SituacaoCarteiraMotorista = SituacaoCarteiraMotorista.Inativa,
                TipoCarteira = TipoCarteira.A
            };
            InserirMotorista(migrationBuilder, motorista, data2);

            motorista = new Motorista()
            {
                Nome = "Jorge Mendes",
                SituacaoCarteiraMotorista = SituacaoCarteiraMotorista.Bloqueada,
                TipoCarteira = TipoCarteira.B
            };
            InserirMotorista(migrationBuilder, motorista, data2);

            motorista = new Motorista()
            {
                Nome = "Carlos Manoel",
                SituacaoCarteiraMotorista = SituacaoCarteiraMotorista.Ativa,
                TipoCarteira = TipoCarteira.C
            };
            InserirMotorista(migrationBuilder, motorista, data1);

            motorista = new Motorista()
            {
                Nome = "Frederico Gaules Kristner",
                SituacaoCarteiraMotorista = SituacaoCarteiraMotorista.Ativa,
                TipoCarteira = TipoCarteira.D
            };
            InserirMotorista(migrationBuilder, motorista, data3);

            motorista = new Motorista()
            {
                Nome = "Julio Frenzy",
                SituacaoCarteiraMotorista = SituacaoCarteiraMotorista.Ativa,
                TipoCarteira = TipoCarteira.C
            };
            InserirMotorista(migrationBuilder, motorista, data3);


            #endregion

            #region CarroMotorista
            #endregion

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }

        private void InserirMotorista(MigrationBuilder migrationBuilder,
            Motorista obj, string dataCriacao)
        {
            migrationBuilder.Sql(
                $"INSERT INTO Motorista (Id, DataCriacao, Nome, SituacaoCarteiraMotorista, TipoCarteira) " +
                $"VALUES ('{obj.Id}', '{dataCriacao}', '{obj.Nome}', '{(int)obj.SituacaoCarteiraMotorista}', '{(int)obj.TipoCarteira}')" +
                $";");
        }

        private void InserirCarroMotorista(MigrationBuilder migrationBuilder,
            CarroMotorista obj, string dataCriacao)
        {
            migrationBuilder.Sql(
                $"INSERT INTO Motorista (Id, DataCriacao, CarroId, MotoristaId) " +
                $"VALUES ('{obj.Id}', '{dataCriacao}', '{obj.CarroId}', '{obj.MotoristaId}')" +
                $";");
        }


    }
}
