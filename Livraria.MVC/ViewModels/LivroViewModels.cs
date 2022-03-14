using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Livraria.MVC.ViewModels
{
    public class LivroViewModels
    {
        
        [Key]
        public int LivroId { get; set; }

        [DisplayName("Código")]
        [Required(ErrorMessage = "Campo Codigo é Obrigatório")]
        public int Codigo { get; set; }

        [DisplayName("Titulo")]
        [Required(ErrorMessage = "Informe o Titulo")]
        [StringLength(100, ErrorMessage = "Máximo {1} Caracteres")]
        [MinLength(5, ErrorMessage = "Minimo {1} Caracteres")]
        public string Titulo { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Informe o Nome")]
        [StringLength(150, ErrorMessage = "Máximo {1} Caracteres")]
        [MinLength(5, ErrorMessage = "Minimo {0} Caracteres")]
        public string Nome { get; set; }

        [DisplayName("Valor")]
        [Required(ErrorMessage = "Informe o Valor")]
        public decimal Preco { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "Informe o Descrição")]
        [StringLength(250, ErrorMessage = "Máximo {1} Caracteres")]
        [MinLength(5, ErrorMessage = "Minimo {1} Caracteres")]
        public string Descricao { get; set; }

        [DisplayName("Resenha")]
        [StringLength(500, ErrorMessage = "Máximo {1} Caracteres")]
        [MinLength(5, ErrorMessage = "Minimo {1} Caracteres")]
        public string Sobre { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [DisplayName("Disponivel?")]
        public bool Disponivel { get; set; }

        public int GeneroId { get; set; }
        public virtual GeneroViewModels Genero { get; set; }

        public virtual ICollection<AutorViewModels> Autores { get; set; }

        public int EditoraId { get; set; }
        public virtual EditoraViewModels Editora { get; set; }
     
        //#region SemProblemas
        //public int LivroId { get; set; }
        //public int Codigo { get; set; }
        //public string Titulo { get; set; }
        //public string Nome { get; set; }
        //public decimal Preco { get; set; }
        //public string Descricao { get; set; }
        //public string Sobre { get; set; }
        //public DateTime DataCadastro { get; set; }
        //public bool Disponivel { get; set; }

        //public int GeneroId { get; set; }
        //public virtual GeneroViewModels Genero { get; set; }

        //public virtual ICollection<AutorViewModels> Autores { get; set; }

        //public int EditoraId { get; set; }
        //public virtual EditoraViewModels Editora { get; set; }

        //#endregion

    }
}