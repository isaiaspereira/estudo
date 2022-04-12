using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Livraria.MVC.ViewModels
{
    public class LoginViewModels
    {
        public int LoginId { get; set; }
        public string Email { get; set; }
        public bool LembrarMe { get; set; }
        public string Senha { get; set; } 
    }
}