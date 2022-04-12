using Livraria.Domain.Entitis;
using System.Collections.Generic;

namespace Livraria.Domain.Interfece.Servico
{
    public    interface IUsuarioService:IServicebase<Usuario>
    {
       IEnumerable<Usuario> BuscaPorNome(string nome);
    }
}
