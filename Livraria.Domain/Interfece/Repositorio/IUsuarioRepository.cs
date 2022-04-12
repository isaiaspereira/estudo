using Livraria.Domain.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Interfece.Repositorio
{
   public interface IUsuarioRepository : IRepositorybase<Usuario>
    {
        IEnumerable<Usuario> BuscaPorNome(string nome);
    }
}
