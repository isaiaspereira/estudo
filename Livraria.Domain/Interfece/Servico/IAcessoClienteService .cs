using Livraria.Domain.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Interfece.Servico
{
    public interface IAcessoClienteService : IServicebase<AcessoCliente>
    {
        IEnumerable<AcessoCliente> BuscaPorNome(string nome);
        AcessoCliente ClienteAutenticate(string email);
        void Add(AcessoCliente acessoCliente, int Id);
    }
}
