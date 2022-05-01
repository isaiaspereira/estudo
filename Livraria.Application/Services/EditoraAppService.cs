using Livraria.Application.Interface;
using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece.Servico;
using System.Collections.Generic;

namespace Livraria.Application
{
    public class EditoraAppService : AppServiceBase<Editora>, IEditoraAppService
    {
        private readonly IEditoraService _EditoraService;
        public EditoraAppService(IEditoraService editoraService) : base(editoraService)
        {
            _EditoraService = editoraService;
        }

        public IEnumerable<Editora> BuscaPorNome(string nome)
        {
            return _EditoraService.BuscaPorNome(nome);
        }

        public void Relacionar(Editora editora, int DestinoId)
        {
            _EditoraService.Relacionar(editora, DestinoId);
        }
    }
}
