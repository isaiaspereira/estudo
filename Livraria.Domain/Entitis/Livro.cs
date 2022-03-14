using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Entitis
{
    public class Livro
    {
        public int LivroId { get; set; }
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public string Sobre { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Disponivel { get; set; }

        public int GeneroId { get; set; }
        public virtual Genero Genero { get; set; }

        public virtual ICollection<Autor> Autores { get; set; }

        public int EditoraId { get; set; }
        public virtual Editora Editora { get; set; }

    }
}
