using AgiliBlueFood.Domain.Entities;
using AgiliBlueFood.Domain.Interfaces.Repositories;
using AgiliBlueFood.Domain.Interfaces.Services;

namespace AgiliBlueFood.Domain.Services
{
    public class BairroService : ServiceBase<Bairro>, IBairroService
    {
        private readonly IBairroRepository _bairroRepository;

        public BairroService(IBairroRepository bairroRepository)
            :base(bairroRepository)
        {
            _bairroRepository = bairroRepository;
        }
    }
}
