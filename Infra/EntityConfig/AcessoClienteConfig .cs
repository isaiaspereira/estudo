using Livraria.Domain.Entitis;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Infra.EntityConfig
{
    public class AcessoClienteConfig : EntityTypeConfiguration<AcessoCliente>
    {
        public AcessoClienteConfig()
        {
            Property(a => a.AcessoClienteId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(a => a.Email).IsRequired().HasMaxLength(150);
            Property(a => a.Senha).HasMaxLength(200).IsRequired();
            HasRequired(c => c.Cliente).WithOptional(c => c.AcessoCliente).WillCascadeOnDelete(false);
            HasMany(c => c.PerfilAcesso).WithMany(c => c.AcessoCliente).Map(c =>
                    {
                        c.MapLeftKey("AcessoClienteId");
                        c.MapRightKey("PerfilAcessoId");
                        c.ToTable("PerfilAcessoCliente");

                    });
        }
    }
}
