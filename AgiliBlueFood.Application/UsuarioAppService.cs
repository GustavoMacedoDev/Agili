using AgiliBlueFood.Application.Interface;
using AgiliBlueFood.Domain.Entities;
using AgiliBlueFood.Domain.Interfaces.Services;
using AgiliBlueFood.Domain.Services;

namespace AgiliBlueFood.Application
{
    public class UsuarioAppService : AppServiceBase<Usuario>, IUsuarioAppService
    {
        private readonly UsuarioService _usuarioService;

        public UsuarioAppService(UsuarioService usuarioService)
            :base(usuarioService)
        {
            _usuarioService = usuarioService;
        }
    }
}
