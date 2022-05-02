using System.Collections.Generic;

namespace Livraria.Domain.Entitis
{
    public class AcessoCliente : Acesso
    {
        public int AcessoClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<PerfilAcesso> PerfilAcesso { get; set; }
    }
}
