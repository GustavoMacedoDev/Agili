
namespace AgiliBlueFood.Domain.Entities
{
    public class Municipio
    {
        public int MunicipioId { get; set; }
        public string NomeMunicipio { get; set; }

        public int EstadoId { get; set; }

        public virtual Estado Estado { get; set; }
    }
}
