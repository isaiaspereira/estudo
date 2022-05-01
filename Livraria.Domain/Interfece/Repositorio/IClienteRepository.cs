using Livraria.Domain.Entitis;
using System.Collections.Generic;

namespace Livraria.Domain.Interfece.Repositorio
{
    public interface IClienteRepository : IRepositorybase<Cliente>
    {
        IEnumerable<Cliente> BuscaPorNome(string nome);
    }
}
