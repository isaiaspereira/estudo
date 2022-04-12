using Livraria.Domain.Entitis;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.EntityConfig
{
   public class AcessoClienteConfig : EntityTypeConfiguration<AcessoCliente>
    {
        public AcessoClienteConfig()
        {
            Property(a=>a.AcessoClienteId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(a => a.Email).IsRequired().HasMaxLength(150);
            Property(a => a.Senha).HasMaxLength(200).IsRequired();
            HasRequired(c => c.Cliente).WithOptional(c => c.AcessoCliente).WillCascadeOnDelete(false);

        }
    }
}
