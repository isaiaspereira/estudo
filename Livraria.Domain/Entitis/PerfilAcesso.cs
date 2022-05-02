using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Entitis
{
  public  class PerfilAcesso
    {
        public int PerfilAcessoId { get; set; }
        public string NomeAcesso { get; set; }
        public virtual ICollection<AcessoCliente> AcessoCliente { get; set; }
        public virtual ICollection<AcessoUsuario> AcessoUsuario { get; set; }
    }
}
