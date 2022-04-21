using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Livraria.MVC.ViewModels
{
    public class AcessoViewModel
    {
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public bool LembrarMe { get; set; }
        [DataType(DataType.Password)]
        public string Senha { get; set; }

    }
}