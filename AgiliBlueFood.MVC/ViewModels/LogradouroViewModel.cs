
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AgiliBlueFood.MVC.ViewModels
{
    public class LogradouroViewModel
    {
        [Key]
        [DisplayName("Logradouro")]
        public int LogradouroId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome do Logradouro")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Nome do Logradouro")]
        public string NomeLogradouro { get; set; }

        [DisplayName("Complemento")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Selecione o Pais")]
        [DisplayName("Nome do País")]
        public int PaisId { get; set; }
        public virtual PaisViewModel Pais { get; set; }

        [Required(ErrorMessage = "Selecione o Estado")]
        [DisplayName("Nome do Estado")]
        public int EstadoId { get; set; }
        public virtual EstadoViewModel Estado { get; set; }

        [Required(ErrorMessage = "Selecione o Municipio")]
        [DisplayName("Nome do Municipio")]
        public int MunicipioId { get; set; }
        public virtual MunicipioViewModel Municipio { get; set; }

        [Required(ErrorMessage = "Selecione o Tipo do Logradouro")]
        [DisplayName("Tipo do Logradouro")]
        public int TipoLogradouroId { get; set; }
        public virtual TipoLogradouroViewModel TipoLogradouro { get; set; }

    }
}