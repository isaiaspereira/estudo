using Livraria.Application.Interface;
using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece.Servico;

namespace Livraria.Application.Services
{
    public class AcessoClienteAppService : AppServiceBase<AcessoCliente>, IAcessoClienteAppService
    {
        IAcessoClienteService _acessoCliente;
        public AcessoClienteAppService(IAcessoClienteService acessoCliente) : base(acessoCliente)
        {
            _acessoCliente = acessoCliente;
        }
    }
}
