using AgiliBlueFood.Domain.Entities;
using AgiliBlueFood.Domain.Interfaces.Repositories;
using AgiliBlueFood.Domain.Interfaces.Services;

namespace AgiliBlueFood.Domain.Services
{
    public class LogradouroService : ServiceBase<Logradouro>, ILogradouroService
    {
        private readonly ILogradouroRepository _logradouroRepository;

        public LogradouroService(ILogradouroRepository logradouroRepository)
            :base(logradouroRepository)
        {
            _logradouroRepository = logradouroRepository;
        }
    }
}
