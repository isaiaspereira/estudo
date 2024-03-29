﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Livraria.MVC.ViewModels
{
    public class ClienteViewModels
    {
        [Key]
        public int ClienteId { get; set; }
        [Required]
        [DisplayName("Nome:")]
        public string Nome { get; set; }
        [Required]
        [DisplayName("CPF:")]
        public string CPF { get; set; }
        [Required]
        [DisplayName("RG:")]
        public string RG { get; set; }
        public virtual AcessoClienteViewModels AcessoClienteView { get; set; }
    }
}