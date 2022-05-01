

using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece;
using Livraria.Domain.Interfece.Servico;
using System.Collections.Generic;

namespace Livraria.Domain.Servico
{
    public class LivroService : ServiceBase<Livro>, ILivroService
    {
        private readonly ILivroRepository _LivroRepository;
        public LivroService(ILivroRepository livroRepository) : base(livroRepository)
        {
            _LivroRepository = livroRepository;
        }

        public IEnumerable<Livro> BuscaPorNome(string nome)
        {
            return _LivroRepository.BuscaPorNome(nome);
        }

        public void Relacionar(Livro livro, int DestinoId)
        {
            _LivroRepository.Relacionar(livro, DestinoId);
        }
    }
}
