
using System;

namespace AgiliBlueFood.Domain.Entities
{
    //Classe de entidade Pessoa Juridica
    public class PessoaJuridica
    {
        //Id da entidade
        public int PessoaJuridicaId { get; set; }
        //campo cnpj
        public string Cnpj { get; set; }
        //campo nome empresarial
        public string NomeEmpresarial { get; set; }
        //campo nome fantasia
        public string NomeFantasia { get; set; }
        //campo data de cadastro
        public DateTime DataCadastro { get; set; }
                       
        public bool Ativo { get; set; }

        public int LogradouroPessoaId { get; set; }
        public virtual Logradouro LogradouroPessoa { get; set; }


    }
}
