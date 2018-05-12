
using AgiliBlueFood.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace AgiliBlueFood.Infra.Data.EntityConfig
{
    public class MunicipioConfiguration : EntityTypeConfiguration<Municipio>
    {
        public MunicipioConfiguration()
        {
            HasKey(m => m.MunicipioId);

            Property(m => m.NomeMunicipio)
                .IsRequired()
                .HasMaxLength(100);

            HasRequired(m => m.Estado)
                .WithMany()
                .HasForeignKey(m => m.EstadoId);
        }
    }
}
