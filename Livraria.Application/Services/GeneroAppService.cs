using Livraria.Application.Interface;
using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Application
{
    public class GeneroAppService : AppServiceBase<Genero>, IGeneroAppService
    {
        private readonly IGeneroService _GeneroService;
        public GeneroAppService(IGeneroService generoService) : base(generoService)
        {
            _GeneroService = generoService;
        }
    }
}
