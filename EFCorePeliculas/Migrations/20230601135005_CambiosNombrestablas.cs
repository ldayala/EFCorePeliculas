using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCorePeliculas.Migrations
{
    /// <inheritdoc />
    public partial class CambiosNombrestablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GeneroPelicula_Genders_GenerosIdentificador",
                table: "GeneroPelicula");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneroPelicula_Movies_PeliculasId",
                table: "GeneroPelicula");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieOffers_Cinemas_CineId",
                table: "MovieOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_PeliculasActores_Actors_ActorId",
                table: "PeliculasActores");

            migrationBuilder.DropForeignKey(
                name: "FK_PeliculasActores_Movies_PeliculaId",
                table: "PeliculasActores");

            migrationBuilder.DropForeignKey(
                name: "FK_PeliculaSalaDeCine_Movies_PeliculasId",
                table: "PeliculaSalaDeCine");

            migrationBuilder.DropForeignKey(
                name: "FK_PeliculaSalaDeCine_SalasCinemas_SalasCinesId",
                table: "PeliculaSalaDeCine");

            migrationBuilder.DropForeignKey(
                name: "FK_SalasCinemas_Cinemas_CineId",
                table: "SalasCinemas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalasCinemas",
                table: "SalasCinemas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieOffers",
                table: "MovieOffers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genders",
                table: "Genders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors",
                table: "Actors");

            migrationBuilder.RenameTable(
                name: "SalasCinemas",
                newName: "SalasDeCines");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "Peliculas");

            migrationBuilder.RenameTable(
                name: "MovieOffers",
                newName: "CineOfertas");

            migrationBuilder.RenameTable(
                name: "Genders",
                newName: "Generos");

            migrationBuilder.RenameTable(
                name: "Actors",
                newName: "Actores");

            migrationBuilder.RenameIndex(
                name: "IX_SalasCinemas_CineId",
                table: "SalasDeCines",
                newName: "IX_SalasDeCines_CineId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieOffers_CineId",
                table: "CineOfertas",
                newName: "IX_CineOfertas_CineId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalasDeCines",
                table: "SalasDeCines",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Peliculas",
                table: "Peliculas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CineOfertas",
                table: "CineOfertas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Generos",
                table: "Generos",
                column: "Identificador");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actores",
                table: "Actores",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CineOfertas_Cinemas_CineId",
                table: "CineOfertas",
                column: "CineId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GeneroPelicula_Generos_GenerosIdentificador",
                table: "GeneroPelicula",
                column: "GenerosIdentificador",
                principalTable: "Generos",
                principalColumn: "Identificador",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GeneroPelicula_Peliculas_PeliculasId",
                table: "GeneroPelicula",
                column: "PeliculasId",
                principalTable: "Peliculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeliculasActores_Actores_ActorId",
                table: "PeliculasActores",
                column: "ActorId",
                principalTable: "Actores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeliculasActores_Peliculas_PeliculaId",
                table: "PeliculasActores",
                column: "PeliculaId",
                principalTable: "Peliculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeliculaSalaDeCine_Peliculas_PeliculasId",
                table: "PeliculaSalaDeCine",
                column: "PeliculasId",
                principalTable: "Peliculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeliculaSalaDeCine_SalasDeCines_SalasCinesId",
                table: "PeliculaSalaDeCine",
                column: "SalasCinesId",
                principalTable: "SalasDeCines",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CineOfertas_Cinemas_CineId",
                table: "CineOfertas");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneroPelicula_Generos_GenerosIdentificador",
                table: "GeneroPelicula");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneroPelicula_Peliculas_PeliculasId",
                table: "GeneroPelicula");

            migrationBuilder.DropForeignKey(
                name: "FK_PeliculasActores_Actores_ActorId",
                table: "PeliculasActores");

            migrationBuilder.DropForeignKey(
                name: "FK_PeliculasActores_Peliculas_PeliculaId",
                table: "PeliculasActores");

            migrationBuilder.DropForeignKey(
                name: "FK_PeliculaSalaDeCine_Peliculas_PeliculasId",
                table: "PeliculaSalaDeCine");

            migrationBuilder.DropForeignKey(
                name: "FK_PeliculaSalaDeCine_SalasDeCines_SalasCinesId",
                table: "PeliculaSalaDeCine");

            migrationBuilder.DropForeignKey(
                name: "FK_SalasDeCines_Cinemas_CineId",
                table: "SalasDeCines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalasDeCines",
                table: "SalasDeCines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Peliculas",
                table: "Peliculas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Generos",
                table: "Generos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CineOfertas",
                table: "CineOfertas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actores",
                table: "Actores");

            migrationBuilder.RenameTable(
                name: "SalasDeCines",
                newName: "SalasCinemas");

            migrationBuilder.RenameTable(
                name: "Peliculas",
                newName: "Movies");

            migrationBuilder.RenameTable(
                name: "Generos",
                newName: "Genders");

            migrationBuilder.RenameTable(
                name: "CineOfertas",
                newName: "MovieOffers");

            migrationBuilder.RenameTable(
                name: "Actores",
                newName: "Actors");

            migrationBuilder.RenameIndex(
                name: "IX_SalasDeCines_CineId",
                table: "SalasCinemas",
                newName: "IX_SalasCinemas_CineId");

            migrationBuilder.RenameIndex(
                name: "IX_CineOfertas_CineId",
                table: "MovieOffers",
                newName: "IX_MovieOffers_CineId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalasCinemas",
                table: "SalasCinemas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genders",
                table: "Genders",
                column: "Identificador");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieOffers",
                table: "MovieOffers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors",
                table: "Actors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GeneroPelicula_Genders_GenerosIdentificador",
                table: "GeneroPelicula",
                column: "GenerosIdentificador",
                principalTable: "Genders",
                principalColumn: "Identificador",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GeneroPelicula_Movies_PeliculasId",
                table: "GeneroPelicula",
                column: "PeliculasId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieOffers_Cinemas_CineId",
                table: "MovieOffers",
                column: "CineId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeliculasActores_Actors_ActorId",
                table: "PeliculasActores",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeliculasActores_Movies_PeliculaId",
                table: "PeliculasActores",
                column: "PeliculaId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeliculaSalaDeCine_Movies_PeliculasId",
                table: "PeliculaSalaDeCine",
                column: "PeliculasId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeliculaSalaDeCine_SalasCinemas_SalasCinesId",
                table: "PeliculaSalaDeCine",
                column: "SalasCinesId",
                principalTable: "SalasCinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalasCinemas_Cinemas_CineId",
                table: "SalasCinemas",
                column: "CineId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
