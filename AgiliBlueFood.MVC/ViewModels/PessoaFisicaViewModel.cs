
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AgiliBlueFood.MVC.ViewModels
{
    public class PessoaFisicaViewModel
    {
        //Id da classe
        [Key]
        public int PessoaFisicaId { get; set; }
        //Atributo Nome da classe de pessoa fisica
        [Required(ErrorMessage ="Preenche o campo Nome")]
        [DisplayName("Nome Completo")]
        public string NomePf { get; set; }

        //Atributo Cpf da classe de pessoa fisica
        [Required(ErrorMessage = "Preenche o campo CPF")]
        [DisplayName("CPF")]
        [MaxLength(11, ErrorMessage = "Máximo de 11 caracteres")]
        [MinLength(11, ErrorMessage = "Mínimo de 11 caracteres")]
        public string Cpf { get; set; }
        //Atributo Endereco da classe
        [Required(ErrorMessage = "Preenche o campo Endereco")]
        [DisplayName("Endereco")]
        public string Endereco { get; set; }


    }
}