using AgiliBlueFood.Application.Interface;
using AgiliBlueFood.Domain.Entities;
using AgiliBlueFood.Domain.Interfaces.Services;

namespace AgiliBlueFood.Application
{
    public class PessoaFisicaAppService : AppServiceBase<PessoaFisica>, IPessoaFisicaAppService
    {
        private readonly IPessoaFisicaService _pessoaFisicaService;

        public PessoaFisicaAppService(IPessoaFisicaService pessoaFisicaService)
            :base(pessoaFisicaService)
        {
            _pessoaFisicaService = pessoaFisicaService;
        }
    }
}
