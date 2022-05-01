using Livraria.Domain.Entitis;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Infra.EntityConfig
{
    public class ContatoConfig : EntityTypeConfiguration<Contato>
    {
        public ContatoConfig()
        {
            HasKey(c => c.ContatoId);
            Property(c => c.ContatoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Telefone1).IsRequired().HasMaxLength(13);
            Property(c => c.Telefone2).IsOptional().HasMaxLength(13);
            HasRequired(c => c.Usuario).WithMany(c => c.Contatos).HasForeignKey(c => c.UsuarioId);
            HasRequired(c => c.Cliente).WithMany(c => c.Contatos).HasForeignKey(c => c.ClienteId);
            HasRequired(c => c.Operadora).WithMany(c => c.Contatos).HasForeignKey(c => c.OperadoraId);



        }
    }
}
