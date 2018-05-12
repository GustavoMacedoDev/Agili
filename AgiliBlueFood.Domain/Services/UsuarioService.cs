using AgiliBlueFood.Domain.Entities;
using AgiliBlueFood.Domain.Interfaces.Repositories;
using AgiliBlueFood.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgiliBlueFood.Domain.Services
{
    public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository) 
            :base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
    }
}
