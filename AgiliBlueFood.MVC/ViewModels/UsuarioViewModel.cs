using AgiliBlueFood.Domain.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AgiliBlueFood.MVC.ViewModels
{
    public class UsuarioViewModel
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Login")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Preencha o campo de senha")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Senha")]
        public string Senha { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }


        [Required(ErrorMessage = "Selecione a pessoa")]
        [DisplayName("Nome da Pessoa Física")]
        public int PessoaFisicaId { get; set; }
        public virtual PessoaFisicaViewModel PessoaFisica { get; set; }
    }
}