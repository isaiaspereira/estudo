using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece.Repositorio;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public IEnumerable<Cliente> BuscaPorNome(string nome)
        {
            return Db.Clientes.Where(c => c.Nome == nome).AsQueryable().OrderBy(c => c.Nome).ToList();
        }
    }
}
