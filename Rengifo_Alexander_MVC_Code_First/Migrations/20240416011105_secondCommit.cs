using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Rengifo_Alexander_MVC_Code_First.Migrations
{
    /// <inheritdoc />
    public partial class secondCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstudianteUdla_EstudianteUdla_EstudianteUdlaIdBanner",
                table: "EstudianteUdla");

            migrationBuilder.DropIndex(
                name: "IX_EstudianteUdla_EstudianteUdlaIdBanner",
                table: "EstudianteUdla");

            migrationBuilder.DropColumn(
                name: "EstudianteUdlaIdBanner",
                table: "EstudianteUdla");

            migrationBuilder.AddColumn<int>(
                name: "RecientoIdRecinto",
                table: "EstudianteUdla",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VacunaIdVacuna",
                table: "EstudianteUdla",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "RecintoVacunacion",
                columns: table => new
                {
                    IdRecinto = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Direccion = table.Column<string>(type: "text", nullable: false),
                    Ciudad = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecintoVacunacion", x => x.IdRecinto);
                });

            migrationBuilder.CreateTable(
                name: "Vacuna",
                columns: table => new
                {
                    IdVacuna = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    PaisProcedencia = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacuna", x => x.IdVacuna);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EstudianteUdla_RecientoIdRecinto",
                table: "EstudianteUdla",
                column: "RecientoIdRecinto");

            migrationBuilder.CreateIndex(
                name: "IX_EstudianteUdla_VacunaIdVacuna",
                table: "EstudianteUdla",
                column: "VacunaIdVacuna");

            migrationBuilder.AddForeignKey(
                name: "FK_EstudianteUdla_RecintoVacunacion_RecientoIdRecinto",
                table: "EstudianteUdla",
                column: "RecientoIdRecinto",
                principalTable: "RecintoVacunacion",
                principalColumn: "IdRecinto",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EstudianteUdla_Vacuna_VacunaIdVacuna",
                table: "EstudianteUdla",
                column: "VacunaIdVacuna",
                principalTable: "Vacuna",
                principalColumn: "IdVacuna",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstudianteUdla_RecintoVacunacion_RecientoIdRecinto",
                table: "EstudianteUdla");

            migrationBuilder.DropForeignKey(
                name: "FK_EstudianteUdla_Vacuna_VacunaIdVacuna",
                table: "EstudianteUdla");

            migrationBuilder.DropTable(
                name: "RecintoVacunacion");

            migrationBuilder.DropTable(
                name: "Vacuna");

            migrationBuilder.DropIndex(
                name: "IX_EstudianteUdla_RecientoIdRecinto",
                table: "EstudianteUdla");

            migrationBuilder.DropIndex(
                name: "IX_EstudianteUdla_VacunaIdVacuna",
                table: "EstudianteUdla");

            migrationBuilder.DropColumn(
                name: "RecientoIdRecinto",
                table: "EstudianteUdla");

            migrationBuilder.DropColumn(
                name: "VacunaIdVacuna",
                table: "EstudianteUdla");

            migrationBuilder.AddColumn<int>(
                name: "EstudianteUdlaIdBanner",
                table: "EstudianteUdla",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EstudianteUdla_EstudianteUdlaIdBanner",
                table: "EstudianteUdla",
                column: "EstudianteUdlaIdBanner");

            migrationBuilder.AddForeignKey(
                name: "FK_EstudianteUdla_EstudianteUdla_EstudianteUdlaIdBanner",
                table: "EstudianteUdla",
                column: "EstudianteUdlaIdBanner",
                principalTable: "EstudianteUdla",
                principalColumn: "IdBanner");
        }
    }
}
