using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCorePeliculas.Migrations
{
    /// <inheritdoc />
    public partial class CambioNombreTAbla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CineOfertas_Cinemas_CineId",
                table: "CineOfertas");

            migrationBuilder.DropForeignKey(
                name: "FK_SalasDeCines_Cinemas_CineId",
                table: "SalasDeCines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cinemas",
                table: "Cinemas");

            migrationBuilder.RenameTable(
                name: "Cinemas",
                newName: "Cine");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cine",
                table: "Cine",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CineOfertas_Cine_CineId",
                table: "CineOfertas",
                column: "CineId",
                principalTable: "Cine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalasDeCines_Cine_CineId",
                table: "SalasDeCines",
                column: "CineId",
                principalTable: "Cine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CineOfertas_Cine_CineId",
                table: "CineOfertas");

            migrationBuilder.DropForeignKey(
                name: "FK_SalasDeCines_Cine_CineId",
                table: "SalasDeCines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cine",
                table: "Cine");

            migrationBuilder.RenameTable(
                name: "Cine",
                newName: "Cinemas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cinemas",
                table: "Cinemas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CineOfertas_Cinemas_CineId",
                table: "CineOfertas",
                column: "CineId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalasDeCines_Cinemas_CineId",
                table: "SalasDeCines",
                column: "CineId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
