using Livraria.Domain.Entitis;
using System.Collections.Generic;

namespace Livraria.Domain.Interfece.Repositorio
{
    public interface IAcessoUsuarioRepository : IRepositorybase<AcessoUsuario>
    {
        IEnumerable<AcessoUsuario> BuscaPorNome(string nome);
        AcessoUsuario UsuarioAutenticate(string email);



    }
}
