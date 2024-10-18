using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FacturaTallerMVC.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellidos = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Recambios",
                columns: table => new
                {
                    IdRecambio = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    Precio = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recambios", x => x.IdRecambio);
                });

            migrationBuilder.CreateTable(
                name: "Coches",
                columns: table => new
                {
                    IdCoche = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Marca = table.Column<string>(type: "TEXT", nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", nullable: false),
                    Combustible = table.Column<string>(type: "TEXT", nullable: false),
                    Kilometros = table.Column<int>(type: "INTEGER", nullable: false),
                    Matricula = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coches", x => x.IdCoche);
                    table.ForeignKey(
                        name: "FK_Coches_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente");
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    IdFactura = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: true),
                    CocheId = table.Column<int>(type: "INTEGER", nullable: true),
                    RecambioId = table.Column<int>(type: "INTEGER", nullable: true),
                    UnidadesRecambio = table.Column<int>(type: "INTEGER", nullable: true),
                    TotalRecambio = table.Column<int>(type: "INTEGER", nullable: true),
                    Trabajo = table.Column<string>(type: "TEXT", nullable: true),
                    UnidadesTrabajo = table.Column<int>(type: "INTEGER", nullable: true),
                    TotalTrabajo = table.Column<int>(type: "INTEGER", nullable: true),
                    Pvp = table.Column<int>(type: "INTEGER", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.IdFactura);
                    table.ForeignKey(
                        name: "FK_Facturas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente");
                    table.ForeignKey(
                        name: "FK_Facturas_Coches_CocheId",
                        column: x => x.CocheId,
                        principalTable: "Coches",
                        principalColumn: "IdCoche");
                    table.ForeignKey(
                        name: "FK_Facturas_Recambios_RecambioId",
                        column: x => x.RecambioId,
                        principalTable: "Recambios",
                        principalColumn: "IdRecambio");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Coches_ClienteId",
                table: "Coches",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_ClienteId",
                table: "Facturas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_CocheId",
                table: "Facturas",
                column: "CocheId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_RecambioId",
                table: "Facturas",
                column: "RecambioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "Coches");

            migrationBuilder.DropTable(
                name: "Recambios");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
