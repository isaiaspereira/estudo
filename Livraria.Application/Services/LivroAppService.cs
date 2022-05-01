using Livraria.Application.Interface;
using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece.Servico;
using System.Collections.Generic;

namespace Livraria.Application
{
    public class LivroAppService : AppServiceBase<Livro>, ILivroAppService
    {
        private readonly ILivroService _LivroService;
        public LivroAppService(ILivroService livroAppService) : base(livroAppService)
        {
            _LivroService = livroAppService;
        }

        public IEnumerable<Livro> BuscaPorNome(string nome)
        {
            return _LivroService.BuscaPorNome(nome);
        }
        public void Relacionar(Livro livro, int DestinoId)
        {
            _LivroService.Relacionar(livro, DestinoId);
        }
    }
}
