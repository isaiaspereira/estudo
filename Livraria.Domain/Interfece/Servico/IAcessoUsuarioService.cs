using Livraria.Domain.Entitis;
using System.Collections.Generic;

namespace Livraria.Domain.Interfece.Servico
{
    public interface IAcessoUsuarioService : IServicebase<AcessoUsuario>
    {
        IEnumerable<AcessoUsuario> BuscaPorNome(string nome);
        AcessoUsuario UsuarioAutenticate(string email);
    }
}
