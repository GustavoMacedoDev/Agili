
using AgiliBlueFood.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace AgiliBlueFood.Infra.Data.EntityConfig
{
    public class LogradouroConfiguration : EntityTypeConfiguration<Logradouro>
    {
        public LogradouroConfiguration()
        {
            HasKey(l => l.LogradouroId);

            Property(l => l.NomeLogradouro)
                .IsRequired()
                .HasMaxLength(150);

            Property(l => l.Complemento)
                .HasMaxLength(200);

            HasRequired(l => l.Pais)
                .WithMany()
                .HasForeignKey(l => l.PaisId);

            HasRequired(l => l.Estado)
                .WithMany()
                .HasForeignKey(l => l.EstadoId);

            HasRequired(l => l.Municipio)
                .WithMany()
                .HasForeignKey(l => l.MunicipioId);

            HasRequired(l => l.TipoLogradouro)
                .WithMany()
                .HasForeignKey(l => l.TipoLogradouroId);
        }

    }
}
