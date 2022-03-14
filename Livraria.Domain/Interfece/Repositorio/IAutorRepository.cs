using Livraria.Domain.Entitis;
using System.Collections.Generic;

namespace Livraria.Domain.Interfece
{
    public interface IAutorRepository : IRepositorybase<Autor>
    {
        IEnumerable<Autor> BuscaPorNome(string nome);
    }
}
