using Livraria.Domain.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Interfece.Repositorio
{
    public interface IAcessoUsuarioRepository : IRepositorybase<AcessoUsuario>
    {
        IEnumerable<AcessoUsuario> BuscaPorNome(string nome);
        AcessoUsuario UsuarioAutenticate(string email);



    }
}
