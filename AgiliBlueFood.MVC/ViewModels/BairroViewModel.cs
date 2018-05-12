using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AgiliBlueFood.MVC.ViewModels
{
    public class BairroViewModel
    {
        [Key]
        public int BairroId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome do Bairro")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Nome do Bairro")]
        public string NomeBairro { get; set; }

        [Required(ErrorMessage = "Selecione o Município")]
        [DisplayName("Nome do Município")]
        public int MunicipioId { get; set; }
        public virtual MunicipioViewModel Municipio { get; set; }

        public int LogradouroPessoaId { get; set; }
        public virtual LogradouroViewModel LogradouroPessoa { get; set; }




    }
}