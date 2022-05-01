using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece;
using Livraria.Domain.Interfece.Servico;

namespace Livraria.Domain.Servico
{
    public class GeneroService : ServiceBase<Genero>, IGeneroService
    {
        private readonly IGeneroRepository _GeneroRepository;
        public GeneroService(IGeneroRepository generoRepository) : base(generoRepository)
        {
            _GeneroRepository = generoRepository;
        }
    }
}
