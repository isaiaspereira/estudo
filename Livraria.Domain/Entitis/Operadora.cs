using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Entitis
{
    public class Operadora
    {
        public int OperadoraId { get; set; }
        public string Nome { get; set; }
        public string DDD { get; set; }
        public int ContatoId { get; set; }
        public ICollection<Contato> Contatos { get; set; }


    }
}
