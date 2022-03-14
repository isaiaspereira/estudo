using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

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