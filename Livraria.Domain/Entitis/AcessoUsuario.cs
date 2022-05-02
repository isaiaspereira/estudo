
using System.Collections.Generic;

namespace Livraria.Domain.Entitis
{
    public class AcessoUsuario : Acesso
    {
        public int AcessoUsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<PerfilAcesso> PerfilAcesso { get; set; }
    }
}
