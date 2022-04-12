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
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            HasKey(c => c.EnderecoId);
            Property(c => c.EnderecoId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Rua).HasMaxLength(150).IsRequired();
            Property(c => c.Logradouro).HasMaxLength(150).IsRequired();
            Property(c => c.CEP).HasMaxLength(9).IsRequired();
            Property(c => c.Bairro).HasMaxLength(150).IsRequired();
            Property(c => c.Referencia).HasMaxLength(150).IsRequired();
            Property(c => c.Cidade).HasMaxLength(150).IsRequired();
            Property(c => c.Estado).HasMaxLength(150).IsRequired();
            HasRequired(c => c.Cliente).WithMany(c => c.Enderecos).HasForeignKey(c => c.ClienteId);
        }
    }
}
