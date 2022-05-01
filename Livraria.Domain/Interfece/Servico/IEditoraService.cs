using Livraria.Domain.Entitis;
using System.Collections.Generic;

namespace Livraria.Domain.Interfece.Servico
{
    public interface IEditoraService : IServicebase<Editora>
    {
        IEnumerable<Editora> BuscaPorNome(string nome);
        void Relacionar(Editora editora, int DestinoId);
    }
}
