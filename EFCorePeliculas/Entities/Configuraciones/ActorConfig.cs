using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace EFCorePeliculas.Entities.Configuraciones
{
    public class ActorConfig : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            //properties actor
            builder.Property(pro => pro.Name)
                .HasMaxLength(150)
                .IsRequired();
            /* modelBuilder.Entity<Actor>().Property(prop => prop.FechaNacimiento)
                 .HasColumnType("date");*/  // ya no lo necesitamos porque lo configuramos arriba en la convencion

        }
    }
}
