using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece;
using Livraria.Domain.Interfece.Servico;
using System.Collections.Generic;

namespace Livraria.Domain.Servico
{
    public class AutorService : ServiceBase<Autor>, IAutorService
    {
        private readonly IAutorRepository _AutorRepository;
        public AutorService(IAutorRepository autorRepository) : base(autorRepository)
        {
            _AutorRepository = autorRepository;
        }

        public IEnumerable<Autor> BuscaPorNome(string nome)
        {
            return _AutorRepository.BuscaPorNome(nome);
        }
    }
}
