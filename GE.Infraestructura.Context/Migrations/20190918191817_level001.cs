using Microsoft.EntityFrameworkCore.Migrations;

namespace GE.Infraestructura.Context.Migrations
{
    public partial class level001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FechaDeIngreso",
                table: "Cliente",
                newName: "FechaIngreso");

            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "Cliente",
                unicode: false,
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Cliente",
                unicode: false,
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Domicilio",
                table: "Cliente",
                unicode: false,
                maxLength: 240,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "Dni",
                table: "Cliente",
                unicode: false,
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Apellido",
                table: "Cliente",
                unicode: false,
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 150);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FechaIngreso",
                table: "Cliente",
                newName: "FechaDeIngreso");

            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "Cliente",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Cliente",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "Domicilio",
                table: "Cliente",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 240);

            migrationBuilder.AlterColumn<string>(
                name: "Dni",
                table: "Cliente",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<string>(
                name: "Apellido",
                table: "Cliente",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 40);
        }
    }
}
