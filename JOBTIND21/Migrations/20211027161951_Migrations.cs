using Microsoft.EntityFrameworkCore.Migrations;

namespace JOBTIND21.Migrations
{
    public partial class Migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id_Empresa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Empresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vacante = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id_Empresa);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id_Usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    DUI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Especializacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id_Usuario);
                });

            migrationBuilder.CreateTable(
                name: "Anuncio",
                columns: table => new
                {
                    Id_Anuncio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Anuncios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Usuario1 = table.Column<int>(type: "int", nullable: true),
                    Id_Empresa1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anuncio", x => x.Id_Anuncio);
                    table.ForeignKey(
                        name: "FK_Anuncio_Empresas_Id_Empresa1",
                        column: x => x.Id_Empresa1,
                        principalTable: "Empresas",
                        principalColumn: "Id_Empresa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Anuncio_Usuarios_Id_Usuario1",
                        column: x => x.Id_Usuario1,
                        principalTable: "Usuarios",
                        principalColumn: "Id_Usuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anuncio_Id_Empresa1",
                table: "Anuncio",
                column: "Id_Empresa1");

            migrationBuilder.CreateIndex(
                name: "IX_Anuncio_Id_Usuario1",
                table: "Anuncio",
                column: "Id_Usuario1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anuncio");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
