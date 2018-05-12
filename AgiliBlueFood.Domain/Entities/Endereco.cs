
namespace AgiliBlueFood.Domain.Entities
{
    public class Endereco
    {
        public int EnderecoId { get; set; }

        public virtual TipoLogradouro TipoLogradouro { get; set; }

        public virtual Bairro Bairro { get; set; }

        


    }
}
