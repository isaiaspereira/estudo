using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Livraria.MVC.ViewModels
{
    public class AutorViewModels
    {
        [Key]
        public int AutorId { get; set; }

        [DisplayName("Nome Autor")]
        [Required(ErrorMessage = "Infome o Nome do Autor")]
        [MaxLength(150, ErrorMessage = "Máximo {0}, Caracteres")]
        [MinLength(10, ErrorMessage = "Minimo {0},Caracteres")]
        public string Nome { get; set; }

        [DisplayName("Sobre Nome")]
        [Required(ErrorMessage = "Infome o Sobre Nome")]
        [MaxLength(200, ErrorMessage = "Máximo {0}, Caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0},Caracteres")]
        public string SobreNome { get; set; }

        [Required(ErrorMessage = "Informe Um E-Mail Válido")]
        [DisplayName("E-Mail")]
        [EmailAddress]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public virtual ICollection<LivroViewModels> Livros { get; set; }

        public virtual ICollection<EditoraViewModels> Editoras { get; set; }
    }
}