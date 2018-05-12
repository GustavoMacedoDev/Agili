
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AgiliBlueFood.MVC.ViewModels
{
    public class TipoLogradouroViewModel
    {
        [Key]
        public int TipoLogradouroId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Tipo do Logradouro")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Tipo do Logradouro")]
        public string TipoDoLogradouro { get; set; }
    }
}