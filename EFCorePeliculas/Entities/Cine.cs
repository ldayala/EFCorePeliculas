using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace EFCorePeliculas.Entities
{
    public class Cine
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
       // [Precision(precision:9,scale:2)] //precision en este caso de 1-9 digitos, scale: decimales depues
        public Point Ubicacion { get; set; }
        public CineOferta OfertaPelicula { get; set; } // propiedad de navegacion, 
        public HashSet<SalaDeCine> SalaDeCines { get; set; }//tambien puede ser una ICollection o IEnumerable si lo quiero ordenar

    }
}
