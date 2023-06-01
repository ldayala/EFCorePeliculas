using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace EFCorePeliculas.Entities.Configuraciones
{
    public class CineConfig : IEntityTypeConfiguration<Cine>
    {
        public void Configure(EntityTypeBuilder<Cine> builder)
        {
            //properties Cine
            builder.Property(pro => pro.Nombre)
                .HasMaxLength(150)
                .IsRequired();
        }
    }
}
