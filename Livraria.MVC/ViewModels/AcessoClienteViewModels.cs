using System.ComponentModel.DataAnnotations;

namespace Livraria.MVC.ViewModels
{
    public class AcessoClienteViewModels : AcessoViewModel
    {
        [Key]
        public int AcessoClienteId { get; set; }
        public virtual ClienteViewModels ClienteViewModels { get; set; }
    }
}