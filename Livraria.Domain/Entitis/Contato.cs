using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Entitis
{
    public class Contato
    {
        public int ContatoId { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public int OperadoraId { get; set; }
        public virtual Operadora Operadora { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
