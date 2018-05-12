using AgiliBlueFood.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace AgiliBlueFood.Infra.Data.EntityConfig
{
    public class TipoLogradouroConfiguration : EntityTypeConfiguration<TipoLogradouro>
    {
        public TipoLogradouroConfiguration()
        {
            HasKey(t => t.TipoLogradouroId);

            Property(t => t.TipoDoLogradouro)
                .IsRequired()
                .HasMaxLength(50);

        }

    }
}
