﻿using EFCorePeliculas.Entities;
using EFCorePeliculas.Entities.Configuraciones;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Writers;
using System.Reflection;

namespace EFCorePeliculas
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        //configuramos las convenciones de entity framework
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>().HaveColumnType("date"); //configuramos para que el tipo DateTime mapea a date en la base de datos 
        }

        //dentro de este metodo se configura el api fluente, dentro del puedo configurar mis entidades y sus propiedades
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfiguration(new GeneroConfig());// importamos la configuracion de GeneroConfig
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());  //importamos toda la configuracion de los config dentro de generoº

            //establecemos la propiedad identificador como llave primaria
           /* modelBuilder.Entity<Genero>().HasKey(p => p.Identificador);  lo tenemos en el archivo de configuracion
            modelBuilder.Entity<Genero>().Property(pro=>pro.Nombre)
               // .HasColumnName("NameGender") //ponemos unn nombre a la columna
                .HasMaxLength(150)
                .IsRequired() ;
            ///modelBuilder.Entity<Gender>().ToTable(name:"TablaGeneros",schema:"Peliculas");// cambiamos el nombre a la tabla y le ponemos un schema
           */
           
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
