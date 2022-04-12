using Livraria.Domain.Entitis;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.EntityConfig
{
   public class AcessoUsuarioConfig:EntityTypeConfiguration<AcessoUsuario>
    {
        public AcessoUsuarioConfig()
        {
            HasKey(a => a.AcessoUsuarioId);
            Property(a=>a.AcessoUsuarioId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            Property(a => a.Email).IsRequired().HasMaxLength(150);
            Property(a => a.Senha).HasMaxLength(200).IsRequired();
            HasRequired(c => c.Usuario).WithOptional(c=>c.AcessoUsuario).WillCascadeOnDelete(false);

        }
    }
}
