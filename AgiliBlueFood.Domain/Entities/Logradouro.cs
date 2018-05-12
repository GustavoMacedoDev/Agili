
namespace AgiliBlueFood.Domain.Entities
{
    public class Logradouro
    {
        public int LogradouroId { get; set; }

        public string NomeLogradouro { get; set; }

        public string Complemento { get; set; }

        public int PaisId { get; set; }
        public virtual Pais Pais { get; set; }

        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }

        public int MunicipioId { get; set; }
        public virtual Municipio Municipio { get; set; }

        public int TipoLogradouroId { get; set; }
        public virtual TipoLogradouro TipoLogradouro {get; set;}

    }

}

