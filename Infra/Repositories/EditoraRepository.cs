using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Repositories
{
    public class EditoraRepository : RepositoryBase<Editora>, IEditoraRepository
    {
        public IEnumerable<Editora> BuscaPorNome(string nome)
        {
            return Db.Editoras.Where(n => n.Nome == nome)
               .AsQueryable()
               .OrderBy(n => nome)
               .ToList();
        }

        public void Relacionar(Editora editora, int DestinoId)
        {
            var AutorRelacionadoEditora = Db.Autores.Find(DestinoId);
            editora.Autores.Add(AutorRelacionadoEditora);
            Db.Editoras.Add(editora);
            Db.SaveChanges();
        }
    }
}
