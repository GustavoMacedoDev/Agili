
using AgiliBlueFood.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace AgiliBlueFood.Infra.Data.EntityConfig
{
    public class BairroConfiguration : EntityTypeConfiguration<Bairro>
    {
        public BairroConfiguration()
        {
            HasKey(b => b.BairroId);

            Property(b => b.NomeBairro)
                .IsRequired()
                .HasMaxLength(100);

            HasRequired(b => b.Municipio)
                .WithMany()
                .HasForeignKey(b => b.MunicipioId);

        }
    }
}
