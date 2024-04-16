using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Rengifo_Alexander_MVC_Code_First.Migrations
{
    /// <inheritdoc />
    public partial class CambiosBdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstudianteUdla",
                columns: table => new
                {
                    IdBanner = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EstudianteUdlaIdBanner = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstudianteUdla", x => x.IdBanner);
                    table.ForeignKey(
                        name: "FK_EstudianteUdla_EstudianteUdla_EstudianteUdlaIdBanner",
                        column: x => x.EstudianteUdlaIdBanner,
                        principalTable: "EstudianteUdla",
                        principalColumn: "IdBanner");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EstudianteUdla_EstudianteUdlaIdBanner",
                table: "EstudianteUdla",
                column: "EstudianteUdlaIdBanner");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstudianteUdla");
        }
    }
}
