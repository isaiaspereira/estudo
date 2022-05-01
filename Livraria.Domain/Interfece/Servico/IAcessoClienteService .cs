using Livraria.Domain.Entitis;
using System.Collections.Generic;

namespace Livraria.Domain.Interfece.Servico
{
    public interface IAcessoClienteService : IServicebase<AcessoCliente>
    {
        IEnumerable<AcessoCliente> BuscaPorNome(string nome);
        AcessoCliente ClienteAutenticate(string email);
        Cliente ClienteOfAccess(string EmailOfcliente);
    }
}
