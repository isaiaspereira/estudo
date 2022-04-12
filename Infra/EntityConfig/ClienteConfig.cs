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
    public class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfig()
        {
            HasKey(c => c.ClienteId);
            Property(c => c.ClienteId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Nome).HasMaxLength(150).IsRequired();
            Property(c => c.CPF).HasColumnName("cpf").HasMaxLength(11).IsRequired();
            Property(c => c.RG).HasMaxLength(11).IsRequired().HasColumnName("rg");
            
            
            //HasRequired(c => c.Enderecos).WithMany();
            //HasRequired(c => c.Contatos).WithMany();
        }
    }
}
