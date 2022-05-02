using Livraria.Domain.Entitis;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Infra.EntityConfig
{
    public class AcessoUsuarioConfig : EntityTypeConfiguration<AcessoUsuario>
    {
        public AcessoUsuarioConfig()
        {
            Property(a => a.AcessoUsuarioId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            Property(a => a.Email).IsRequired().HasMaxLength(150);
            Property(a => a.Senha).HasMaxLength(200).IsRequired();
            HasRequired(c => c.Usuario).WithOptional(c => c.AcessoUsuario).WillCascadeOnDelete(false);
            HasMany(c => c.PerfilAcesso).WithMany(c => c.AcessoUsuario).Map(c =>
                {
                    c.MapLeftKey("AcessoUsuarioId");
                    c.MapRightKey("PerfilAcessoId");
                    c.ToTable("PerfilAcessoUsuario");
                });
        }
    }
}
