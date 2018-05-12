using AgiliBlueFood.Application.Interface;
using AgiliBlueFood.Domain.Entities;
using AgiliBlueFood.Domain.Interfaces.Services;

namespace AgiliBlueFood.Application
{
    public class MunicipioAppService : AppServiceBase<Municipio>, IMunicipioAppService
    {
        private readonly IMunicipioService _municipioService;

        public MunicipioAppService(IMunicipioService municipioService)
            :base(municipioService)
        {
            _municipioService = municipioService;
        }
    }
}
