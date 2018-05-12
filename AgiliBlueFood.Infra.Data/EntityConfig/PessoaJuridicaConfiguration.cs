
using AgiliBlueFood.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace AgiliBlueFood.Infra.Data.EntityConfig
{
    public class PessoaJuridicaConfiguration : EntityTypeConfiguration<PessoaJuridica>
    {
        public PessoaJuridicaConfiguration()
        {
            HasKey(p => p.PessoaJuridicaId);

            Property(p => p.Cnpj)
                .IsRequired();
                
            Property(p => p.NomeEmpresarial)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.NomeFantasia)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
