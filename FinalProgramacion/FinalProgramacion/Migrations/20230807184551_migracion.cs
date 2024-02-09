using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FinalProgramacion.Migrations
{
    /// <inheritdoc />
    public partial class migracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ciudads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    PaisId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ciudads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ciudads_pais_PaisId",
                        column: x => x.PaisId,
                        principalTable: "pais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "barrios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CiudadId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_barrios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_barrios_ciudads_CiudadId",
                        column: x => x.CiudadId,
                        principalTable: "ciudads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "depositos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Activo = table.Column<bool>(type: "boolean", nullable: false),
                    metrosCuadrados = table.Column<int>(type: "integer", nullable: false),
                    calle = table.Column<string>(type: "text", nullable: false),
                    numero = table.Column<string>(type: "text", nullable: false),
                    BarrioId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_depositos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_depositos_barrios_BarrioId",
                        column: x => x.BarrioId,
                        principalTable: "barrios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_barrios_CiudadId",
                table: "barrios",
                column: "CiudadId");

            migrationBuilder.CreateIndex(
                name: "IX_ciudads_PaisId",
                table: "ciudads",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_depositos_BarrioId",
                table: "depositos",
                column: "BarrioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "depositos");

            migrationBuilder.DropTable(
                name: "barrios");

            migrationBuilder.DropTable(
                name: "ciudads");

            migrationBuilder.DropTable(
                name: "pais");
        }
    }
}
