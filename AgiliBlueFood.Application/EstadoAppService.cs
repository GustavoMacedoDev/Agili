
using AgiliBlueFood.Application.Interface;
using AgiliBlueFood.Domain.Entities;
using AgiliBlueFood.Domain.Interfaces.Services;

namespace AgiliBlueFood.Application
{
    public class EstadoAppService : AppServiceBase<Estado>, IEstadoAppService
    {
        private readonly IEstadoService _estadoService;

        public EstadoAppService(IEstadoService estadoService)
            :base(estadoService)
        {
            _estadoService = estadoService;
        }

    }
}
