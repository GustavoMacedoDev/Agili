
using System;

namespace AgiliBlueFood.Domain.Entities
{
    public class Login
    {
        public int LoginId { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

    }
}
