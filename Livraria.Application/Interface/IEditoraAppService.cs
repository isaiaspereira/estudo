using Livraria.Domain.Entitis;
using System.Collections.Generic;

namespace Livraria.Application.Interface
{
    public interface IEditoraAppService : IAppSeriveBase<Editora>
    {
        IEnumerable<Editora> BuscaPorNome(string nome);
        void Relacionar(Editora editora, int DestinoId);
    }
}
