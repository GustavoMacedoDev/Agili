using System;
using System.ComponentModel.DataAnnotations;

namespace AgiliBlueFood.MVC.ViewModels
{
    public class LoginViewModel
    {
        [Key]
        public int LoginId { get; set; }

        [Required(ErrorMessage ="Preencha o campo Usuario")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(1, ErrorMessage = "Mínimo {0} caracteres")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Preencha o campo Senha")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(1, ErrorMessage = "Mínimo {0} caracteres")]
        public string Senha { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

    }
}