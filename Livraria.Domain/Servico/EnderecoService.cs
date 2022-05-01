using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece.Repositorio;
using Livraria.Domain.Interfece.Servico;

namespace Livraria.Domain.Servico
{
    public class EnderecoService : ServiceBase<Endereco>, IEnderecoService
    {
        private readonly IEnderecoRepository _EnderecoRepository;
        public EnderecoService(IEnderecoRepository enderecoRepository) : base(enderecoRepository)
        {
            _EnderecoRepository = enderecoRepository;
        }

    }
}
