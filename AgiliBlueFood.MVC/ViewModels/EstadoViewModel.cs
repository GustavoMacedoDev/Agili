
using AgiliBlueFood.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AgiliBlueFood.MVC.ViewModels
{
    public class EstadoViewModel
    {
        [Key]
        public int EstadoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome do Estado")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Nome do Estado")]
        public string NomeEstado { get; set; }

        [Required(ErrorMessage = "Preencha o campo Sigla - Composto por duas letras")]
        [MaxLength(2, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Sigla do Estado")]
        public string SiglaEstado { get; set; }

        
        [Required(ErrorMessage = "Selecione o País")]
        public int PaisId { get; set; }

        public virtual PaisViewModel Pais { get; set; }

    }
}