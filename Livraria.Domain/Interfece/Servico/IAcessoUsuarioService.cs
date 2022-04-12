using Livraria.Domain.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Interfece.Servico
{
    public interface IAcessoUsuarioService:IServicebase<AcessoUsuario>
    {
        IEnumerable<AcessoUsuario> BuscaPorNome(string nome);
        AcessoUsuario UsuarioAutenticate(string email);
    }
}
