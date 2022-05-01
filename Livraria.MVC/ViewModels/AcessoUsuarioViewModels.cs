using System.ComponentModel.DataAnnotations;

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