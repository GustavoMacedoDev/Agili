
using AgiliBlueFood.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace AgiliBlueFood.Infra.Data.EntityConfig
{
    public class PessoaFisicaConfiguration : EntityTypeConfiguration<PessoaFisica>
    {
        public PessoaFisicaConfiguration()
        {
            HasKey(p => p.PessoaFisicaId);

            Property(p => p.NomePf)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Cpf)
                .IsRequired()
                .HasMaxLength(11);

            Property(p => p.Endereco)
                .IsRequired()
                .HasMaxLength(150);

        }

    }
}
