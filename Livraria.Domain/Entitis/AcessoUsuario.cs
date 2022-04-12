using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Entitis
{
    public class AcessoUsuario : Acesso
    {
        public int AcessoUsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
