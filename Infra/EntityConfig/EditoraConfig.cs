using Livraria.Domain.Entitis;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Infra.EntityConfig
{
    public class EditoraConfig : EntityTypeConfiguration<Editora>
    {
        public EditoraConfig()
        {
            HasKey(k => k.EditoraId);
            Property(p => p.EditoraId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //definindo as configuraçao das tabela
            Property(p => p.Nome).HasMaxLength(250).IsRequired();
            Property(p => p.Sigla).HasMaxLength(10).IsRequired();
            //mapenado o relacionamento da tabela
            HasMany(m => m.Autores).WithMany(c => c.Editoras).Map(x => { x.MapLeftKey("EditoraId"); x.MapRightKey("AutorId"); });
        }
    }
}
