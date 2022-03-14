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
   public class EditoraService:ServiceBase<Editora>,IEditoraService
    {
        private readonly IEditoraRepository _EditoraRepository;
        public EditoraService(IEditoraRepository editoraRepository):base(editoraRepository)
        {
            _EditoraRepository = editoraRepository;
        }

        public IEnumerable<Editora> BuscaPorNome(string nome)
        {
            return _EditoraRepository.BuscaPorNome(nome);
        }

        public void Relacionar(Editora editora, int DestinoId)
        {
            _EditoraRepository.Relacionar(editora,DestinoId);
        }
    }
}
