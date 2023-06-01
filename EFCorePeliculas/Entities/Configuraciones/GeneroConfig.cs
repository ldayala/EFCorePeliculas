using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace EFCorePeliculas.Entities.Configuraciones
{
    public class GeneroConfig : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.HasKey(p => p.Identificador);
            builder.Property(pro => pro.Nombre)
                // .HasColumnName("NameGender") //ponemos unn nombre a la columna
                .HasMaxLength(150)
                .IsRequired();
        }
    }
}
