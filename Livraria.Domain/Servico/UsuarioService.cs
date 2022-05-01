using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece.Repositorio;
using Livraria.Domain.Interfece.Servico;
using System.Collections.Generic;

namespace Livraria.Domain.Servico
{
    public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepository _UsuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository) : base(usuarioRepository)
        {
            _UsuarioRepository = usuarioRepository;
        }

        public IEnumerable<Usuario> BuscaPorNome(string nome)
        {
            return _UsuarioRepository.BuscaPorNome(nome);
        }
    }
}
