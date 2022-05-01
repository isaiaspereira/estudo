using System;

namespace Livraria.MVC.ViewModels
{
    public class UsuarioViewModels
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public string RG { get; set; }
        public string Cargo { get; set; }
        public string CTPS { get; set; }
        public decimal Salario { get; set; }
        public virtual AcessoUsuarioViewModels AcessoUsuario { get; set; }
    }
}