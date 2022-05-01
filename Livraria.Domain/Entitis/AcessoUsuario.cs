namespace Livraria.Domain.Entitis
{
    public class AcessoUsuario : Acesso
    {
        public int AcessoUsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
