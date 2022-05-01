using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Repositories
{
    public class GeneroRepository : RepositoryBase<Genero>, IGeneroRepository
    {
        public IEnumerable<Genero> BuscaPorNome(string nome)
        {

            var GeneroDomain = Db.Generos.Where(n => n.Tipo == nome).AsQueryable();
            return GeneroDomain.ToList().OrderBy(c => c.Tipo);
        }
    }
}
