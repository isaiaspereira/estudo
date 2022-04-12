using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece.Repositorio;
using Livraria.Domain.Interfece.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Servico
{
   public class ClienteService:ServiceBase<Cliente>,IClienteService
    {
        private readonly IClienteRepository _ClienteRepository;
        public ClienteService(IClienteRepository clienteRepository):base(clienteRepository)
        {
            _ClienteRepository=clienteRepository;
        }

        public IEnumerable<Cliente> BuscaPorNome(string nome)
        {
            return _ClienteRepository.BuscaPorNome(nome);
        }
    }
}
