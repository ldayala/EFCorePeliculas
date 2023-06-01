using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace EFCorePeliculas.Entities.Configuraciones
{
    public class PeliculaActorConfig : IEntityTypeConfiguration<PeliculaActor>
    {
        public void Configure(EntityTypeBuilder<PeliculaActor> builder)
        {

            builder.Property(prop => prop.Personaje)
                .HasMaxLength(150);
            builder.HasKey(prop =>
                new { prop.PeliculaId, prop.ActorId }); //para que la llave primaria sea compuesta por los dos id
        }
    }
}
