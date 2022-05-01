using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece.Repositorio;
using System.Collections.Generic;

namespace Infra.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public IEnumerable<Usuario> BuscaPorNome(string nome)
        {
            return BuscaPorNome(nome);
        }
    }
}
