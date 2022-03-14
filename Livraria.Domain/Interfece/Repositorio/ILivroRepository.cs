using Livraria.Domain.Entitis;
using System.Collections.Generic;

namespace Livraria.Domain.Interfece
{
    public interface ILivroRepository : IRepositorybase<Livro>
    {
        IEnumerable<Livro> BuscaPorNome(string nome);
        void Relacionar(Livro livro, int DestinoId);
    }
}
