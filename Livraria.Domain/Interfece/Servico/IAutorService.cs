using Livraria.Domain.Entitis;
using System.Collections.Generic;

namespace Livraria.Domain.Interfece.Servico
{
    public interface IAutorService : IServicebase<Autor>
    {
        IEnumerable<Autor> BuscaPorNome(string nome);
    }
}
