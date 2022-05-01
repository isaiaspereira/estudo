using System.ComponentModel.DataAnnotations;

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