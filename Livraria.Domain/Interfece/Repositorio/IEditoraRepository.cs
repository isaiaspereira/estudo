using Livraria.Domain.Entitis;
using System.Collections.Generic;

namespace Livraria.Domain.Interfece
{
    public interface IEditoraRepository : IRepositorybase<Editora>
    {
        IEnumerable<Editora> BuscaPorNome(string nome);
        void Relacionar(Editora editora, int DestinoId);
    }
}
