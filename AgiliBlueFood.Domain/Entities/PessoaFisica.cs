
namespace AgiliBlueFood.Domain.Entities
{
    /*
     Esse e a minha classe de entidade do banco de dados, nela tem os mesmos campos da tabela do banco de dados
     caso queira alterar o nome de algum campo ou inserir novo devo colocar aqui
     Se for uma classe nova devo colocar ela no Dbset para o Entity persistir ela no banco
         */
    public class PessoaFisica
    {
        //Id da classe
        public int PessoaFisicaId { get; set; }
        //Atributo Nome da classe de pessoa fisica
        public string  NomePf { get; set; }
        //Atributo Cpf da classe de pessoa fisica
        public string Cpf { get; set; }
        //Atributo Endereco da classe
        public string Endereco { get; set; }

    }
}
