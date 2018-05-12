using AgiliBlueFood.Domain.Entities;
using AgiliBlueFood.Domain.Interfaces.Repositories;
using AgiliBlueFood.Domain.Interfaces.Services;

namespace AgiliBlueFood.Domain.Services
{
    public class PessoaFisicaService : ServiceBase<PessoaFisica>, IPessoaFisicaService
    {

        private readonly IPessoaFisicaRepository _pessoaFisicaRepository;

        public PessoaFisicaService(IPessoaFisicaRepository pessoaFisicaRepository)
            :base(pessoaFisicaRepository)
        {
            _pessoaFisicaRepository = pessoaFisicaRepository;
            _pessoaFisicaRepository = pessoaFisicaRepository;
        }
    }
}
