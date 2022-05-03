using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece.Repositorio;
using Livraria.Domain.Interfece.Servico;
using System;
using System.Collections.Generic;

namespace Livraria.Domain.Servico
{
    public class AcessoClienteService : ServiceBase<AcessoCliente>, IAcessoClienteService
    {
        private readonly IAcessoClienteRepository _AcessoClienteRepository;
        public AcessoClienteService(IAcessoClienteRepository acessoClienteRepository) : base(acessoClienteRepository)
        {
            _AcessoClienteRepository = acessoClienteRepository;

        }


        public IEnumerable<AcessoCliente> BuscaPorNome(string nome)
        {
            return _AcessoClienteRepository.BuscaPorNome(nome);
        }

        public AcessoCliente ClienteAutenticate(string email)
        {
            return _AcessoClienteRepository.ClienteAutenticate(email);
        }

        public Cliente ClienteOfAccess(string EmailOfcliente)
        {
            return _AcessoClienteRepository.ClienteOfAccess(EmailOfcliente);
        }

        public string[] GetNamePerfilAcesso(string EmailOfPrfil)
        {
            return _AcessoClienteRepository.GetNamePerfilAcesso( EmailOfPrfil);
        }
    }
}
