
using System.Collections.Generic;

namespace AgiliBlueFood.Domain.Entities
{
    public class Pais
    {
        public int PaisId { get; set; }
        public string NomePais { get; set; }
        public string Sigla { get; set; }

        public virtual IEnumerable<Pais> Paises { get; set; }

    }
}
