using AgiliBlueFood.Application.Interface;
using AgiliBlueFood.Domain.Entities;
using AgiliBlueFood.Domain.Interfaces.Services;

namespace AgiliBlueFood.Application
{
    public class BairroAppService : AppServiceBase<Bairro>, IBairroAppService
    {
        private readonly IBairroService _bairroService;


        public BairroAppService(IBairroService bairroService)
            :base(bairroService)
        {
            _bairroService = bairroService;
        }

    }
}
