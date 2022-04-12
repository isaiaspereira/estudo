using Livraria.Domain.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Application.Interface
{
    public interface IAutorAppService : IAppServiceBase<Autor>
    {
        IEnumerable<Autor> BuscaPorNome(string nome);
    }
}
