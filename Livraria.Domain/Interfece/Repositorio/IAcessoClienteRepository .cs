using Livraria.Domain.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Interfece.Repositorio
{
    public interface IAcessoClienteRepository : IRepositorybase<AcessoCliente>
    {
        IEnumerable<AcessoCliente> BuscaPorNome(string nome);
        AcessoCliente ClienteAutenticate(string nameCliente);

        Cliente ClienteOfAccess(string EmailOfcliente);

    }
}
