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
   public class OperadoraConfig:EntityTypeConfiguration<Operadora>
    {
        public OperadoraConfig()
        {
            HasKey(c => c.OperadoraId);
            Property(c => c.OperadoraId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Nome).HasMaxLength(50).IsRequired();
            Property(c => c.DDD).IsRequired().HasMaxLength(5);
            
        }
    }
}
