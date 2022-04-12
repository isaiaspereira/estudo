using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece.Repositorio;
using Livraria.Domain.Interfece.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Servico
{
    public class EnderecoService:ServiceBase<Endereco>,IEnderecoService
    {
        private readonly IEnderecoRepository _EnderecoRepository;
        public EnderecoService(IEnderecoRepository enderecoRepository):base(enderecoRepository)
        {
            _EnderecoRepository = enderecoRepository;
        }

    }
}
