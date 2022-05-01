using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Livraria.MVC.ViewModels
{
    public class EditoraViewModels
    {
        [Key]
        public int EditoraId { get; set; }
        [DisplayName("Nome")]
        [Required(ErrorMessage = "Infome o Nome da Editora")]
        [MaxLength(100, ErrorMessage = "Máximo {0},Caracteres")]
        [MinLength(5, ErrorMessage = "Minimo {0},Caracteres")]
        public string Nome { get; set; }

        [DisplayName("Sigla")]
        [Required(ErrorMessage = "Infome o Nome da Editora")]
        [MaxLength(10, ErrorMessage = "Máximo {0},Caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0},Caracteres")]
        public string Sigla { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public virtual ICollection<AutorViewModels> Autores { get; set; }

        public virtual ICollection<LivroViewModels> Livros { get; set; }
    }
}