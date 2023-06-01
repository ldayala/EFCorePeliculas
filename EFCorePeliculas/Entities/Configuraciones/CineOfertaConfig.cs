using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace EFCorePeliculas.Entities.Configuraciones
{
    public class CineOfertaConfig : IEntityTypeConfiguration<CineOferta>
    {
        public void Configure(EntityTypeBuilder<CineOferta> builder)
        {
            //properties MovieOffer
            builder.Property(prop => prop.PorcentajeDescuento)
                .HasPrecision(precision: 5, scale: 1);
        }
    }
}
