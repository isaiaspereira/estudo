using Livraria.Application.Interface;
using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece.Servico;

namespace Livraria.Application
{
    public class GeneroAppService : AppServiceBase<Genero>, IGeneroAppService
    {
        private readonly IGeneroService _GeneroService;
        public GeneroAppService(IGeneroService generoService) : base(generoService)
        {
            _GeneroService = generoService;
        }
    }
}
