using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Entitis
{
    public class Genero
    {
        public int GeneroId { get; set; }
        public string Tipo { get; set; }
        public virtual ICollection<Livro> Livros { get; set; }
    }
}
