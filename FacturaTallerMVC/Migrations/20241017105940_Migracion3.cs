using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FacturaTallerMVC.Migrations
{
    /// <inheritdoc />
    public partial class Migracion3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Facturas_IdCliente",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Coches_Clientes_IdCoche",
                table: "Coches");

            migrationBuilder.DropForeignKey(
                name: "FK_Coches_Facturas_IdCoche",
                table: "Coches");

            migrationBuilder.DropForeignKey(
                name: "FK_Recambios_Facturas_IdRecambio",
                table: "Recambios");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio",
                table: "Recambios",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Facturas",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MatriculaId",
                table: "Facturas",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecambioId",
                table: "Facturas",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Coches",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_ClienteId",
                table: "Facturas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_MatriculaId",
                table: "Facturas",
                column: "MatriculaId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_RecambioId",
                table: "Facturas",
                column: "RecambioId");

            migrationBuilder.CreateIndex(
                name: "IX_Coches_ClienteId",
                table: "Coches",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Coches_Clientes_ClienteId",
                table: "Coches",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "IdCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Clientes_ClienteId",
                table: "Facturas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "IdCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Coches_MatriculaId",
                table: "Facturas",
                column: "MatriculaId",
                principalTable: "Coches",
                principalColumn: "IdCoche");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Recambios_RecambioId",
                table: "Facturas",
                column: "RecambioId",
                principalTable: "Recambios",
                principalColumn: "IdRecambio");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coches_Clientes_ClienteId",
                table: "Coches");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Clientes_ClienteId",
                table: "Facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Coches_MatriculaId",
                table: "Facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Recambios_RecambioId",
                table: "Facturas");

            migrationBuilder.DropIndex(
                name: "IX_Facturas_ClienteId",
                table: "Facturas");

            migrationBuilder.DropIndex(
                name: "IX_Facturas_MatriculaId",
                table: "Facturas");

            migrationBuilder.DropIndex(
                name: "IX_Facturas_RecambioId",
                table: "Facturas");

            migrationBuilder.DropIndex(
                name: "IX_Coches_ClienteId",
                table: "Coches");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Facturas");

            migrationBuilder.DropColumn(
                name: "MatriculaId",
                table: "Facturas");

            migrationBuilder.DropColumn(
                name: "RecambioId",
                table: "Facturas");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Coches");

            migrationBuilder.AlterColumn<int>(
                name: "Precio",
                table: "Recambios",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Facturas_IdCliente",
                table: "Clientes",
                column: "IdCliente",
                principalTable: "Facturas",
                principalColumn: "IdFactura",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Coches_Clientes_IdCoche",
                table: "Coches",
                column: "IdCoche",
                principalTable: "Clientes",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Coches_Facturas_IdCoche",
                table: "Coches",
                column: "IdCoche",
                principalTable: "Facturas",
                principalColumn: "IdFactura",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recambios_Facturas_IdRecambio",
                table: "Recambios",
                column: "IdRecambio",
                principalTable: "Facturas",
                principalColumn: "IdFactura",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
