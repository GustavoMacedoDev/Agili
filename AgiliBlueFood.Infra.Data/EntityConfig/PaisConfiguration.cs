
using AgiliBlueFood.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace AgiliBlueFood.Infra.Data.EntityConfig
{
    public class PaisConfiguration : EntityTypeConfiguration<Pais>
    {
        public PaisConfiguration()
        {
            HasKey(p => p.PaisId);

            Property(p => p.NomePais)
                .IsRequired()
                .HasMaxLength(100);

            Property(p => p.Sigla)
                .IsRequired()
                .HasMaxLength(2);

        }
    }
}
