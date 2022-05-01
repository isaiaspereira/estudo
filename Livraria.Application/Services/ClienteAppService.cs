using Livraria.Application.Interface;
using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece.Servico;

namespace Livraria.Application.Services
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        IClienteService _ClienteService;
        public ClienteAppService(IClienteService clienteService) : base(clienteService)
        {
            _ClienteService = clienteService;
        }
    }
}
