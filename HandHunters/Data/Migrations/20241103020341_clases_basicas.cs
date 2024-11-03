using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HandHunters.Data.Migrations
{
    /// <inheritdoc />
    public partial class clases_basicas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "calidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCalidad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_calidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "estados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEstado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "franquicias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreFranquicia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_franquicias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "idiomas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreIdioma = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_idiomas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "cartas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCarta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Costo = table.Column<double>(type: "float", nullable: false),
                    IdCalidad = table.Column<int>(type: "int", nullable: false),
                    CalidadId = table.Column<int>(type: "int", nullable: false),
                    IdEstado = table.Column<int>(type: "int", nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    IdIdioma = table.Column<int>(type: "int", nullable: false),
                    IdiomaId = table.Column<int>(type: "int", nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdFranquicia = table.Column<int>(type: "int", nullable: false),
                    FranquiciaId = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cartas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cartas_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_cartas_calidades_CalidadId",
                        column: x => x.CalidadId,
                        principalTable: "calidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cartas_estados_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "estados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cartas_franquicias_FranquiciaId",
                        column: x => x.FranquiciaId,
                        principalTable: "franquicias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cartas_idiomas_IdiomaId",
                        column: x => x.IdiomaId,
                        principalTable: "idiomas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cartas_CalidadId",
                table: "cartas",
                column: "CalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_cartas_EstadoId",
                table: "cartas",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_cartas_FranquiciaId",
                table: "cartas",
                column: "FranquiciaId");

            migrationBuilder.CreateIndex(
                name: "IX_cartas_IdiomaId",
                table: "cartas",
                column: "IdiomaId");

            migrationBuilder.CreateIndex(
                name: "IX_cartas_UserId",
                table: "cartas",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cartas");

            migrationBuilder.DropTable(
                name: "calidades");

            migrationBuilder.DropTable(
                name: "estados");

            migrationBuilder.DropTable(
                name: "franquicias");

            migrationBuilder.DropTable(
                name: "idiomas");
        }
    }
}
