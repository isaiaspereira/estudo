using Livraria.Domain.Entitis;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.EntityConfig
{
    public class PerfilAcessoConfig : EntityTypeConfiguration<PerfilAcesso>
    {
        public PerfilAcessoConfig()
        {
            HasKey(c => c.PerfilAcessoId);
            Property(c => c.PerfilAcessoId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(c => c.NomeAcesso).HasMaxLength(50).IsRequired().HasColumnType("nvarchar");
            HasMany(c => c.AcessoCliente).WithMany(c => c.PerfilAcesso).Map(c =>
            {
                c.MapLeftKey("PerfilAcessoId");
                c.MapRightKey("AcessoClienteId");
                c.ToTable("PerfilAcessoCliente");
            });

            HasMany(c => c.AcessoUsuario).WithMany(c => c.PerfilAcesso).Map(c =>
            {
                c.MapLeftKey("PerfilAcessoId");
                c.MapRightKey("AcessoUsuarioId");
                c.ToTable("PerfilAcessoUsuario");
            });
        }
    }
}
