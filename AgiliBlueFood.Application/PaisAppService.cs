
using AgiliBlueFood.Application.Interface;
using AgiliBlueFood.Domain.Entities;
using AgiliBlueFood.Domain.Interfaces.Services;

namespace AgiliBlueFood.Application
{
    public class PaisAppService : AppServiceBase<Pais>, IPaisAppService
    {
        private readonly IPaisService _paisService;

        public PaisAppService(IPaisService paisService)
            :base(paisService)
        {
            _paisService = paisService;
        }
    }
}
