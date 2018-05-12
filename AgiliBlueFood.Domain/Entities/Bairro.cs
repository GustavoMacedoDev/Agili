
namespace AgiliBlueFood.Domain.Entities
{
    public class Bairro
    {
        public int BairroId { get; set; }
        public string NomeBairro { get; set; }

        public int MunicipioId { get; set; }

        public virtual Municipio Municipio { get; set; }


    }
}
