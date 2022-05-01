using Livraria.Domain.Entitis;
using System.Collections.Generic;

namespace Livraria.Application.Interface
{
    public interface IAutorAppService : IAppSeriveBase<Autor>
    {
        IEnumerable<Autor> BuscaPorNome(string nome);
    }
}
