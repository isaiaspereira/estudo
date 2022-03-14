using Livraria.Domain.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Interfece.Servico
{
   public  interface ILivroService:IServicebase<Livro>
    {
        IEnumerable<Livro> BuscaPorNome(string nome);
        void Relacionar(Livro livro, int DestinoId);
    }
}
