using Microsoft.EntityFrameworkCore.Migrations;

namespace FrontEnd.API.Migrations
{
    public partial class SegundaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdMarca",
                table: "Modelos");

            migrationBuilder.DropColumn(
                name: "IdCombustible",
                table: "Autos");

            migrationBuilder.DropColumn(
                name: "IdEstado",
                table: "Autos");

            migrationBuilder.DropColumn(
                name: "IdMarca",
                table: "Autos");

            migrationBuilder.DropColumn(
                name: "IdModelo",
                table: "Autos");

            migrationBuilder.DropColumn(
                name: "IdTipo",
                table: "Autos");

            migrationBuilder.DropColumn(
                name: "IdTransmision",
                table: "Autos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdMarca",
                table: "Modelos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCombustible",
                table: "Autos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEstado",
                table: "Autos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdMarca",
                table: "Autos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdModelo",
                table: "Autos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdTipo",
                table: "Autos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdTransmision",
                table: "Autos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
