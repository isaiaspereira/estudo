using Livraria.Domain.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Interfece.Servico
{
    public interface IEditoraService : IServicebase<Editora>
    {
        IEnumerable<Editora> BuscaPorNome(string nome);
        void Relacionar(Editora editora, int DestinoId);
    }
}
