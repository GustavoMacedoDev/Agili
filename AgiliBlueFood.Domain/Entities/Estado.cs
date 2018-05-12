

namespace AgiliBlueFood.Domain.Entities
{
    public class Estado
    {
        public int EstadoId { get; set; }
        public string NomeEstado { get; set; }
        public string SiglaEstado { get; set; }

        public int PaisId { get; set; }

        public virtual Pais Pais { get; set; }


    }
}

