using Livraria.Domain.Entitis;
using System.Collections.Generic;

namespace Livraria.Domain.Interfece.Repositorio
{
    public interface IUsuarioRepository : IRepositorybase<Usuario>
    {
        IEnumerable<Usuario> BuscaPorNome(string nome);
    }
}
