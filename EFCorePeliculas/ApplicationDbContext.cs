using EFCorePeliculas.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCorePeliculas
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        //dentro de este metodo se configura el api fluente, dentro del puedo configurar mis entidades y sus propiedades
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //establecemos la propiedad identificador como llave primaria
            modelBuilder.Entity<Genero>().HasKey(p => p.Identificador);
            modelBuilder.Entity<Genero>().Property(pro=>pro.Nombre)
               // .HasColumnName("NameGender") //ponemos unn nombre a la columna
                .HasMaxLength(150)
                .IsRequired() ;
            ///modelBuilder.Entity<Gender>().ToTable(name:"TablaGeneros",schema:"Peliculas");// cambiamos el nombre a la tabla y le ponemos un schema

            //properties actor
            modelBuilder.Entity<Actor>().Property(pro => pro.Name)
                .HasMaxLength(150)
                .IsRequired();
            modelBuilder.Entity<Actor>().Property(prop => prop.FechaNacimiento)
                .HasColumnType("date");

            //properties Cinema
            modelBuilder.Entity<Cine>().Property(pro => pro.Nombre)
                .HasMaxLength(150)
                .IsRequired() ;
           

            //properties peliculas
            modelBuilder.Entity<Pelicula>().Property(pro=>pro.Titulo)
                .HasMaxLength(250)
                .IsRequired() ;
            modelBuilder.Entity<Pelicula>().Property(pro => pro.FechaEstreno)
               .HasColumnType("date");
            modelBuilder.Entity<Pelicula>().Property(pro => pro.PosterURL)
               .HasMaxLength(500)
               .IsUnicode(false); //en false no podemos almacenar carecteres arabes ni la ñ

            //properties MovieOffer
            modelBuilder.Entity<CineOferta>().Property(prop => prop.PorcentajeDescuento)
                .HasPrecision(precision: 5, scale: 1);
            modelBuilder.Entity<CineOferta>().Property(prop => prop.FechaInicio)
                .HasColumnType ("date");
            modelBuilder.Entity<CineOferta>().Property(prop => prop.FechaFin)
                .HasColumnType ("date");

            //properties SalasCinema
            modelBuilder.Entity<SalaDeCine>().Property(prop => prop.Precio)
                .HasPrecision(precision:5,scale: 2);
            modelBuilder.Entity<SalaDeCine>().Property(prop => prop.tipoSalaDeCine)
                .HasDefaultValue(TipoSalaDeCine.DosDimensiones); //establecemos un valor por defecto a la propiedad
                                                                 //properties PeliculaActor
            modelBuilder.Entity<PeliculaActor>().Property(prop => prop.Personaje)
                .HasMaxLength(150);
            modelBuilder.Entity<PeliculaActor>().HasKey(prop =>
                new { prop.PeliculaId, prop.ActorId }); //para que la llave primaria sea compuesta por los dos id


        }
        public DbSet<Genero> Genders { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Cine> Cinemas { get; set; }
        public DbSet <Pelicula> Movies { get;}
        public DbSet<CineOferta> MovieOffers { get; set; }
        public DbSet<SalaDeCine> SalasCinemas { get; set; }
        public DbSet<PeliculaActor> PeliculasActores { get; set; }
    }

    
}
