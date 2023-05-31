using System.ComponentModel.DataAnnotations.Schema;

namespace EFCorePeliculas.Entities
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Biografia { get; set; }
       // [Column(TypeName ="Date")] //para que se mapee en la db date sin hora
        public DateTime? FechaNacimiento { get; set; }
        public HashSet<PeliculaActor> PeliculasActores { get; set; }
        
    }
}
