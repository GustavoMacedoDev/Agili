
using AgiliBlueFood.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace AgiliBlueFood.Infra.Data.EntityConfig
{
    public class EstadoConfiguration : EntityTypeConfiguration<Estado>
    {
        public EstadoConfiguration()
        {
            HasKey(e => e.EstadoId);

            Property(e => e.NomeEstado)
                .IsRequired()
                .HasMaxLength(100);

            Property(e => e.SiglaEstado)
                .IsRequired()
                .HasMaxLength(2);

            HasRequired(e => e.Pais)
                .WithMany()
                .HasForeignKey(e => e.PaisId);


        }

    }
}
