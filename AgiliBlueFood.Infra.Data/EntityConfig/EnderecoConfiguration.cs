
using AgiliBlueFood.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace AgiliBlueFood.Infra.Data.EntityConfig
{
    public class EnderecoConfiguration : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfiguration()
        {
            HasKey(e => e.EnderecoId);
            
        }
    }
}
