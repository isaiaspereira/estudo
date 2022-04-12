using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Livraria.MVC.ViewModels
{
    public class AcessoUsuarioViewModels
    {
        [Key]
        public string Email { get; set; }
        public bool LembrarMe { get; set; }
        public string Senha { get; set; }
        public int AcessoClienteId { get; set; }
        public virtual UsuarioViewModels UsuarioViewModels { get; set; }
    }
}