using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FacturaTallerMVC.Migrations
{
    /// <inheritdoc />
    public partial class MigracionResetA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Matricula",
                table: "Coches",
                type: "TEXT",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Matricula",
                table: "Coches");
        }
    }
}
