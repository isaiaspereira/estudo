using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class AcessoUsuarioRepository : RepositoryBase<AcessoUsuario>, IAcessoUsuarioRepository
    {
        public AcessoUsuario UsuarioAutenticate(string email)
        {
            return Db.AcessoUsuarios.Where(c => c.Email.Trim() == email.Trim()).FirstOrDefault();
        }

        IEnumerable<AcessoUsuario> IAcessoUsuarioRepository.BuscaPorNome(string email)
        {
            return Db.AcessoUsuarios.Where(c => c.Email.Trim() == email.Trim()).AsQueryable().OrderBy(c => c.Email).ToList();
        }
    }
}
