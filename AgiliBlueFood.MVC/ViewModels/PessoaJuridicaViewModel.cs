
using System;
using System.ComponentModel.DataAnnotations;

namespace AgiliBlueFood.MVC.ViewModels
{
    public class PessoaJuridicaViewModel
    {
        //Id da entidade
        [Key]
        public int PessoaJuridicaId { get; set; }
        
        //campo cnpj
        [Required(ErrorMessage = "Preencha o campo CNPJ")]       
        [MaxLength(14, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(14, ErrorMessage = "Mínimo {0} caracteres")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome Empresarial")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        //campo nome empresarial
        public string NomeEmpresarial { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome Fantasia")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        //campo nome fantasia
        public string NomeFantasia { get; set; }


        //campo data de cadastro
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

    }
}