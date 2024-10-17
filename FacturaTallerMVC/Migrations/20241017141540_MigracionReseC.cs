using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FacturaTallerMVC.Migrations
{
    /// <inheritdoc />
    public partial class MigracionReseC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Coches_MatriculaId",
                table: "Facturas");

            migrationBuilder.RenameColumn(
                name: "MatriculaId",
                table: "Facturas",
                newName: "CocheId");

            migrationBuilder.RenameIndex(
                name: "IX_Facturas_MatriculaId",
                table: "Facturas",
                newName: "IX_Facturas_CocheId");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Coches_CocheId",
                table: "Facturas",
                column: "CocheId",
                principalTable: "Coches",
                principalColumn: "IdCoche");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Coches_CocheId",
                table: "Facturas");

            migrationBuilder.RenameColumn(
                name: "CocheId",
                table: "Facturas",
                newName: "MatriculaId");

            migrationBuilder.RenameIndex(
                name: "IX_Facturas_CocheId",
                table: "Facturas",
                newName: "IX_Facturas_MatriculaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Coches_MatriculaId",
                table: "Facturas",
                column: "MatriculaId",
                principalTable: "Coches",
                principalColumn: "IdCoche");
        }
    }
}
