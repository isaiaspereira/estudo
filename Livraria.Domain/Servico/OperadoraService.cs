using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece.Repositorio;
using Livraria.Domain.Interfece.Servico;

namespace Livraria.Domain.Servico
{
    public class OperadoraService : ServiceBase<Operadora>, IOperadoraService
    {
        private readonly IOperadoraRepository _OperadoraRepository;
        public OperadoraService(IOperadoraRepository operadoraRepository) : base(operadoraRepository)
        {
            _OperadoraRepository = operadoraRepository;
        }


    }
}
