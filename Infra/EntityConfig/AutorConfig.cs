using Livraria.Domain.Entitis;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Infra.EntityConfig
{
    class AutorConfig : EntityTypeConfiguration<Autor>
    {
        public AutorConfig()
        {
            HasKey(k => k.AutorId);
            Property(p => p.AutorId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Nome).HasColumnName("nomeautor").HasMaxLength(150).IsRequired();
            Property(p => p.SobreNome).HasMaxLength(180).IsRequired();
            Property(p => p.Email).HasMaxLength(100).IsRequired();
            HasMany(m => m.Editoras).WithMany(c => c.Autores).Map(x => { x.MapLeftKey("AutorId"); x.MapRightKey("EditoraId"); });
            HasMany(m => m.Livros).WithMany(c => c.Autores).Map(x => { x.MapLeftKey("AutorId"); x.MapRightKey("LivroId"); });
        }
    }
}
