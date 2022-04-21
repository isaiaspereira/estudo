using Livraria.Application.Interface;
using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Application.Services
{
   public class ClienteAppService:AppServiceBase<Cliente>,IClienteAppService
    {
        IClienteService _ClienteService;
        public ClienteAppService(IClienteService clienteService):base(clienteService)
        {
            _ClienteService = clienteService;
        }
    }
}
