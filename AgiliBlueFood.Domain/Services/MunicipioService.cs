using AgiliBlueFood.Domain.Entities;
using AgiliBlueFood.Domain.Interfaces.Repositories;
using AgiliBlueFood.Domain.Interfaces.Services;

namespace AgiliBlueFood.Domain.Services
{
    public class MunicipioService : ServiceBase<Municipio>, IMunicipioService
    {
        private readonly IMunicipioRepository _municipioRepository;

        public MunicipioService(IMunicipioRepository municipioRepository)
            :base(municipioRepository)
        {
            _municipioRepository = municipioRepository;
        }
    }
}
