
using System;

namespace AgiliBlueFood.Domain.Entities
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public int PessoaFisicaId { get; set; }
        public virtual PessoaFisica PessoaFisica { get; set; }

    }
}
