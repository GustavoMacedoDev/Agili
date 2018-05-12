
using AgiliBlueFood.Application.Interface;
using AgiliBlueFood.Domain.Entities;
using AgiliBlueFood.Domain.Interfaces.Services;

namespace AgiliBlueFood.Application
{
    public class PessoaJuridicaAppService : AppServiceBase<PessoaJuridica>, IPessoaJuridicaAppService
    {
        private readonly IPessoaJuridicaService _pessoaJuridicaService;

        public PessoaJuridicaAppService(IPessoaJuridicaService pessoaJuridicaService)
            :base(pessoaJuridicaService)
        {
            _pessoaJuridicaService = pessoaJuridicaService;
        }


    }
}
