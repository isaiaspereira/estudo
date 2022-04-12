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
    public class AcessoClienteAppService : AppServiceBase<AcessoCliente>, IAcessoClienteAppService
    {
        IAcessoClienteService _acessoCliente;
        public AcessoClienteAppService(IAcessoClienteService acessoCliente):base(acessoCliente)
        {
            _acessoCliente = acessoCliente;
        }
    }
}
