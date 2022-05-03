using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece.Repositorio;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Repositories
{
    public class AcessoClienteRepository : RepositoryBase<AcessoCliente>, IAcessoClienteRepository
    {

        public AcessoCliente ClienteAutenticate(string email)
        {
            return Db.AcessoClientes.Where(c => c.Email.Trim() == email.Trim()).FirstOrDefault();
        }

        public IEnumerable<AcessoCliente> BuscaPorNome(string email)
        {
            return Db.AcessoClientes.Where(c => c.Email.Trim() == email.Trim()).AsQueryable().OrderBy(c => c.Email).ToList();
        }

        public Cliente ClienteOfAccess(string EmailOfcliente)
        {
            int IdAccessClient = Db.AcessoClientes.Where(c => c.Email.Trim().ToLower() == EmailOfcliente.ToLower().Trim()).Select(c => c.AcessoClienteId).FirstOrDefault();
            return Db.Clientes.Where(c => c.ClienteId == IdAccessClient).FirstOrDefault();
        }

        public string[] GetNamePerfilAcesso(string EmailOfPrfil)
        {
            var NamesPerfilAcesso = Db.AcessoClientes.Where(c=>c.Email==EmailOfPrfil).FirstOrDefault();
            return NamesPerfilAcesso.PerfilAcesso.Select(c => c.NomeAcesso).ToArray();
        }
    }
}
