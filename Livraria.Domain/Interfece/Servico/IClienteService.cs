using Livraria.Domain.Entitis;
using System.Collections.Generic;

namespace Livraria.Domain.Interfece.Servico
{
    public interface IClienteService : IServicebase<Cliente>
    {
        IEnumerable<Cliente> BuscaPorNome(string nome);
    }
}
