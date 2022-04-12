using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Entitis
{
    public class AcessoCliente : Acesso
    {
        public int AcessoClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
