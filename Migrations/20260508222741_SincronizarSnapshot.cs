using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalHealth_.Migrations
{
    /// <inheritdoc />
    public partial class SincronizarSnapshot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SenhaGrafico",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "FotoPerfil",
                table: "Usuarios");
        }
    }
}