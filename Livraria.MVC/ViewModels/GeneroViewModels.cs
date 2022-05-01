using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Livraria.MVC.ViewModels
{
    public class GeneroViewModels
    {
        [Key]
        public int GeneroId { get; set; }
        public string Tipo { get; set; }
        public virtual IEnumerable<LivroViewModels> Livros { get; set; }
    }
}