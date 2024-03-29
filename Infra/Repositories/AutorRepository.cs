﻿using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Repositories
{
    public class AutorRepository : RepositoryBase<Autor>, IAutorRepository
    {
        public IEnumerable<Autor> BuscaPorNome(string nome)
        {
            return Db.Autores.Where(n => n.Nome == nome)
                .AsQueryable()
                .OrderBy(n => nome)
                .ToList();
        }
    }
}
