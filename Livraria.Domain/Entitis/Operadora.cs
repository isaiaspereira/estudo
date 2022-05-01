using System.Collections.Generic;

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
