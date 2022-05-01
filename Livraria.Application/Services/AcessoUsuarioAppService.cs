using Livraria.Application.Interface;
using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece.Servico;

namespace Livraria.Application.Services
{
    public class AcessoUsuarioAppService : AppServiceBase<AcessoUsuario>, IAcessoUsuarioAppService
    {
        IAcessoUsuarioService _acessoUsuario;
        public AcessoUsuarioAppService(IAcessoUsuarioService acessoUsuario) : base(acessoUsuario)
        {
            _acessoUsuario = acessoUsuario;
        }
    }
}
