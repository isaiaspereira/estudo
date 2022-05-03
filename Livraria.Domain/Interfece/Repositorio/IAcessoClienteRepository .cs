using Livraria.Domain.Entitis;
using System.Collections.Generic;

namespace Livraria.Domain.Interfece.Repositorio
{
    public interface IAcessoClienteRepository : IRepositorybase<AcessoCliente>
    {
        IEnumerable<AcessoCliente> BuscaPorNome(string nome);
        AcessoCliente ClienteAutenticate(string nameCliente);
        Cliente ClienteOfAccess(string EmailOfcliente);
        string[] GetNamePerfilAcesso(string EmailOfPrfil);

    }
}
