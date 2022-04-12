using Livraria.Domain.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Application.Interface
{
    public interface IEditoraAppService : IAppServiceBase<Editora>
    {
        IEnumerable<Editora> BuscaPorNome(string nome);
        void Relacionar(Editora editora, int DestinoId);
    }
}
