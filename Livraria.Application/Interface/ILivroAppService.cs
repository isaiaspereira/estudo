using Livraria.Domain.Entitis;
using System.Collections.Generic;

namespace Livraria.Application.Interface
{
    public interface ILivroAppService : IAppSeriveBase<Livro>
    {
        IEnumerable<Livro> BuscaPorNome(string nome);
        void Relacionar(Livro livro, int DestinoId);
    }
}
