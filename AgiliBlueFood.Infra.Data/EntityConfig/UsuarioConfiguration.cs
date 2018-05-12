using AgiliBlueFood.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace AgiliBlueFood.Infra.Data.EntityConfig
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            HasKey(u => u.UsuarioId);

            Property(u => u.Login)
                .IsRequired()
                .HasMaxLength(20);

            Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(100);

            Property(u => u.DataCadastro)
                .IsRequired();

            Property(u => u.Ativo)
                .IsRequired();

            HasRequired(u => u.PessoaFisica)
                .WithMany()
                .HasForeignKey(u => u.PessoaFisicaId);
        }
    }
}
