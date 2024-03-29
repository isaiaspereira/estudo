﻿using System;
using System.Collections.Generic;

namespace Livraria.Domain.Entitis
{
    public class Editora
    {
        public int EditoraId { get; set; }

        public string Nome { get; set; }

        public DateTime DataCadastro { get; set; }

        public string Sigla { get; set; }

        public virtual ICollection<Autor> Autores { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }
    }
}
