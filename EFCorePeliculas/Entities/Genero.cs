using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCorePeliculas.Entities
{
    //[Table("TablaGeneros",Schema ="peliculas")] //mombre para la tabla, esquema
    public class Genero
    { 
        /* si quisieramos definir una clave primaria que no contenga la palabra id lo hacemos asi con el api fluente
        *///[Key] lo comento para hacerlo a travez del api fluente
       public int Identificador { get; set; }

        // public int Id { get; set; }
        //[StringLength(150)]  establceemos un tamaño maximo a Name
        //[MaxLength(150)]  lo comentamos para hacerlo en el api fluente
        //[Required]
        // [Column("NombreGenero")] nombre a la columna
        public string Nombre { get; set; }
        public HashSet<Pelicula> Peliculas { get; set;}
    }
}
