
using AgiliBlueFood.Application.Interface;
using AgiliBlueFood.Domain.Entities;
using AgiliBlueFood.Domain.Interfaces.Services;

namespace AgiliBlueFood.Application
{
    public class LogradouroAppService : AppServiceBase<Logradouro>, ILogradouroAppService
    {
        private readonly ILogradouroService _logradouroService;

        public LogradouroAppService(ILogradouroService logradouroService)
            :base(logradouroService)
        {
            _logradouroService = logradouroService;
        }
    }
}
