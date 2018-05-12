
using System.ComponentModel.DataAnnotations;

namespace AgiliBlueFood.MVC.ViewModels
{
    public class PaisViewModel
    {
        [Key]
        public int PaisId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome do Pais")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(1, ErrorMessage = "Mínimo {0} caracteres")]
        public string NomePais { get; set; }

        [Required(ErrorMessage = "Preencha o campo Sigla")]
        [MaxLength(2, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Sigla { get; set; }
    }
}