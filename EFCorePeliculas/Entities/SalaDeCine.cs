namespace EFCorePeliculas.Entities
{
    public class SalaDeCine
    {
        public int Id { get; set; }
        // [Precision(precision:9,scale:2)] //precision en este caso de 1-9 digitos, scale: decimales depues
        public decimal Precio { get; set; }
        public TipoSalaDeCine tipoSalaDeCine { get; set; }
        public int CineId { get; set; }
        public Cine Cine { get; set;}
        public HashSet<Pelicula> Peliculas { get;}
    }
}
