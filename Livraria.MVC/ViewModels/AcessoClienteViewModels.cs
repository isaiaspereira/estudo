using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Livraria.MVC.ViewModels
{
    public class AcessoClienteViewModels:AcessoViewModel
    {
        [Key]
        public int AcessoClienteId { get; set; }
        public virtual ClienteViewModels ClienteViewModels { get; set; }
    }
}