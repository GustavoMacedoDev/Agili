using AgiliBlueFood.Domain.Entities;
using AgiliBlueFood.Domain.Interfaces.Repositories;
using AgiliBlueFood.Domain.Interfaces.Services;

namespace AgiliBlueFood.Domain.Services
{
    public class TipoLogradouroService : ServiceBase<TipoLogradouro>, ITipoLogradouroService
    {
        private readonly ITipoLogradouroRepository _TipoLogradouroRepository;


        public TipoLogradouroService(ITipoLogradouroRepository tipoLogradouroRepository)
            :base(tipoLogradouroRepository)
        {
            _TipoLogradouroRepository = tipoLogradouroRepository;

        }
    }
}
