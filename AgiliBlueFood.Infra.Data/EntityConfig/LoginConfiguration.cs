using AgiliBlueFood.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace AgiliBlueFood.Infra.Data.EntityConfig
{
    public class LoginConfiguration : EntityTypeConfiguration<Login>
    {
        public LoginConfiguration()
        {
            HasKey(l => l.LoginId);

            Property(l => l.Usuario)
                .IsRequired()
                .HasMaxLength(50);

            Property(l => l.Senha)
                .IsRequired()
                .HasMaxLength(50);
        }

    }
}
