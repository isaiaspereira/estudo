using Livraria.Domain.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Application.Interface
{
    public interface ILivroAppService : IAppSeriveBase<Livro>
    {
        IEnumerable<Livro> BuscaPorNome(string nome);
        void Relacionar(Livro livro, int DestinoId);
    }
}
