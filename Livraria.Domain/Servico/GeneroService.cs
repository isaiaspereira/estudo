using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece;
using Livraria.Domain.Interfece.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Servico
{
    public class GeneroService:ServiceBase<Genero>,IGeneroService
    {
        private readonly IGeneroRepository _GeneroRepository;
        public GeneroService(IGeneroRepository generoRepository):base(generoRepository)
        {
            _GeneroRepository = generoRepository;
        }
    }
}
