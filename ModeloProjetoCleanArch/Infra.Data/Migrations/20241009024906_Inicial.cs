using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fabricante",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCriacao = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DataAtualizacao = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fabricante", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Motorista",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SituacaoCarteiraMotorista = table.Column<int>(type: "int", nullable: false),
                    TipoCarteira = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DataAtualizacao = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motorista", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carro",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FabricanteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCriacao = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DataAtualizacao = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carro_Fabricante_FabricanteId",
                        column: x => x.FabricanteId,
                        principalTable: "Fabricante",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CarroMotorista",
                columns: table => new
                {
                    CarroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MotoristaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarroMotorista", x => new { x.CarroId, x.MotoristaId });
                    table.ForeignKey(
                        name: "FK_CarroMotorista_Carro_CarroId",
                        column: x => x.CarroId,
                        principalTable: "Carro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarroMotorista_Motorista_MotoristaId",
                        column: x => x.MotoristaId,
                        principalTable: "Motorista",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chassi",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumeroDeSerie = table.Column<long>(type: "bigint", nullable: false),
                    CarroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCriacao = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DataAtualizacao = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chassi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chassi_Carro_CarroId",
                        column: x => x.CarroId,
                        principalTable: "Carro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carro_FabricanteId",
                table: "Carro",
                column: "FabricanteId");

            migrationBuilder.CreateIndex(
                name: "IX_CarroMotorista_MotoristaId",
                table: "CarroMotorista",
                column: "MotoristaId");

            migrationBuilder.CreateIndex(
                name: "IX_Chassi_CarroId",
                table: "Chassi",
                column: "CarroId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarroMotorista");

            migrationBuilder.DropTable(
                name: "Chassi");

            migrationBuilder.DropTable(
                name: "Motorista");

            migrationBuilder.DropTable(
                name: "Carro");

            migrationBuilder.DropTable(
                name: "Fabricante");
        }
    }
}
