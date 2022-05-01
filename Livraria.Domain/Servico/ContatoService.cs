using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece.Repositorio;
using Livraria.Domain.Interfece.Servico;

namespace Livraria.Domain.Servico
{
    public class ContatoService : ServiceBase<Contato>, IContatoService
    {
        private readonly IContatoRepository _ContatoRepository;
        public ContatoService(IContatoRepository contatoRepository) : base(contatoRepository)
        {
            _ContatoRepository = contatoRepository;
        }
    }

}
