using AgiliBlueFood.Application.Interface;
using AgiliBlueFood.Domain.Entities;
using AgiliBlueFood.Domain.Interfaces.Services;

namespace AgiliBlueFood.Application
{
    public class TipoLogradouroAppService : AppServiceBase<TipoLogradouro>, ITipoLogradouroAppService
    {
        private readonly ITipoLogradouroService _tipoLogradouroService;

        public TipoLogradouroAppService(ITipoLogradouroService tipoLogradouroService)
            :base(tipoLogradouroService)
        {
            _tipoLogradouroService = tipoLogradouroService;
        }
    }
}
