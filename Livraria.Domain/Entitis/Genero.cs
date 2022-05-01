using System.Collections.Generic;

namespace Livraria.Domain.Entitis
{
    public class Genero
    {
        public int GeneroId { get; set; }
        public string Tipo { get; set; }
        public virtual ICollection<Livro> Livros { get; set; }
    }
}
