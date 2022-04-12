using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Livraria.MVC.ViewModels
{
    public class ClienteViewModels
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public AcessoClienteViewModels acessoClienteView { get; set; }
    }
}