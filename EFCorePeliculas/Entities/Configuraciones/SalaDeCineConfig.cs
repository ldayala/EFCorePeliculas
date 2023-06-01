using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace EFCorePeliculas.Entities.Configuraciones
{
    public class SalaDeCineConfig : IEntityTypeConfiguration<SalaDeCine>
    {
        public void Configure(EntityTypeBuilder<SalaDeCine> builder)
        {
            //properties SalasCinema
            builder.Property(prop => prop.Precio)
                .HasPrecision(precision: 5, scale: 2);
            builder.Property(prop => prop.tipoSalaDeCine)
                .HasDefaultValue(TipoSalaDeCine.DosDimensiones); //establecemos un valor por defecto a la propiedad
                                                                 //properties PeliculaActor
        }
    }
}
