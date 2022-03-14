using System.Collections.Generic;
using Livraria.Application.Interface;
using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece.Servico;

namespace Livraria.Application
{
    public class AutorAppService : AppServiceBase<Autor>, IAutorAppService
    {
        private readonly IAutorService _AutorService;
        public AutorAppService(IAutorService autorService) : base(autorService)
        {
            _AutorService = autorService;
        }

        public IEnumerable<Autor> BuscaPorNome(string nome)
        {
            return _AutorService.BuscaPorNome(nome);
        }
    }
}
