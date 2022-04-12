using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece.Repositorio;
using Livraria.Domain.Interfece.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Servico
{
    public class AcessoUsuarioService : ServiceBase<AcessoUsuario>, IAcessoUsuarioService
    {
        private readonly IAcessoUsuarioRepository _AcessoRepository;
        public AcessoUsuarioService(IAcessoUsuarioRepository acessoRepository):base(acessoRepository)
        {
            _AcessoRepository = acessoRepository;

        }

        public IEnumerable<AcessoUsuario> BuscaPorNome(string nome)
        {
            throw new NotImplementedException();
        }
        
        public AcessoUsuario UsuarioAutenticate(string email)
        {
           return _AcessoRepository.UsuarioAutenticate(email);
        }
    }
}
