
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AgiliBlueFood.MVC.ViewModels
{
    public class MunicipioViewModel
    {
        [Key]
        public int MunicipioId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome do Município")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Nome do Municipio")]
        public string NomeMunicipio { get; set; }

        [Required(ErrorMessage = "Selecione o Estado")]
        [DisplayName("Nome do Estado")]
        public int EstadoId { get; set; }

        public virtual EstadoViewModel Estado { get; set; }
    }
}