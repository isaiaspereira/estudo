using Livraria.Domain.Entitis;
using System.Collections.Generic;

namespace Livraria.Domain.Interfece.Servico
{
    public interface ILivroService : IServicebase<Livro>
    {
        IEnumerable<Livro> BuscaPorNome(string nome);
        void Relacionar(Livro livro, int DestinoId);
    }
}
