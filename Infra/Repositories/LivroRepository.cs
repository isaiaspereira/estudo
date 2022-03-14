using Infra.Context;
using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class LivroRepository : RepositoryBase<Livro>, ILivroRepository
    {
        public IEnumerable<Livro> BuscaPorNome(string nome)
        {
            return Db.Livros.Where(n => n.Nome == nome).AsQueryable().OrderBy(n => n.Nome).ToList();
        }

        public void Relacionar(Livro livro, int DestinoId)
        {

                var Autor = Db.Autores.Find(DestinoId);
                livro.Autores.Add(Autor);
                Db.Livros.Add(livro);
                Db.SaveChanges();
            
           
        }
    }
}
