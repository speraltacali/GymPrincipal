using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GE.Infraestructura.Context.Migrations
{
    public partial class newmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Apellido = table.Column<string>(maxLength: 150, nullable: false),
                    Nombre = table.Column<string>(maxLength: 150, nullable: false),
                    Dni = table.Column<string>(maxLength: 15, nullable: false),
                    Telefono = table.Column<string>(maxLength: 25, nullable: false),
                    Domicilio = table.Column<string>(maxLength: 300, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Sexo = table.Column<int>(nullable: false),
                    GrupoSanguineo = table.Column<int>(nullable: false),
                    FechaDeIngreso = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
