using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace EFCorePeliculas.Entities.Configuraciones
{
    public class PeliculaConfig : IEntityTypeConfiguration<Pelicula>
    {
        public void Configure(EntityTypeBuilder<Pelicula> builder)
        {
            //properties peliculas
            builder.Property(pro => pro.Titulo)
                .HasMaxLength(250)
            .IsRequired();

            builder.Property(pro => pro.PosterURL)
               .HasMaxLength(500)
               .IsUnicode(false); //en false no podemos almacenar carecteres arabes ni la ñ

        }
    }
}
