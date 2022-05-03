using AutoMapper;
using Livraria.Application.Interface;
using Livraria.Domain.Entitis;
using Livraria.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Livraria.MVC.Controllers
{
    [Authorize(Roles = "Presidente,Administrativo")]
    public class LivroController : Controller
    {
        private readonly ILivroAppService _LivroApp;
        private readonly IAutorAppService _AutorApp;
        private readonly IGeneroAppService _GeneroApp;
        private readonly IEditoraAppService _EditoraApp;

        public LivroController(ILivroAppService livroApp,
            IAutorAppService autorApp,
            IGeneroAppService generoApp,
            IEditoraAppService editoraApp)
        {
            _LivroApp = livroApp;
            _GeneroApp = generoApp;
            _EditoraApp = editoraApp;
            _AutorApp = autorApp;

        }
        // GET: Livro

        public ActionResult Index(string Pesquisa = "")
        {
            if (Request.IsAjaxRequest())
            {
                var PesquisarPorNome = _LivroApp.BuscaPorNome(Pesquisa);
                var livroView = Mapper.Map<IEnumerable<Livro>, IEnumerable<LivroViewModels>>(PesquisarPorNome);
                return PartialView("_BuscaPorNome", livroView);
            }

            var livroViewModels = Mapper.Map<IEnumerable<Livro>, IEnumerable<LivroViewModels>>(_LivroApp.GetAll());

            return View(livroViewModels);
        }

        // GET: Livro/Details/5
        public ActionResult Details(int id)
        {
            var LivroVm = Mapper.Map<Livro, LivroViewModels>(_LivroApp.GetById(id));
            return View(LivroVm);
        }
        public ActionResult Create()
        {
            ViewBag.GeneroId = new SelectList(_GeneroApp.GetAll(), "GeneroId", "Tipo");
            ViewBag.EditoraId = new SelectList(_EditoraApp.GetAll(), "EditoraId", "Nome");
            ViewBag.AutorId = new SelectList(_AutorApp.GetAll(), "AutorId", "Nome");
            return View();
        }
        // POST: Livro/Create
        [HttpPost, ActionName("Create")]
        public ActionResult Create(LivroViewModels LivroViewModel, int? AutorId)
        {
            var AutorPorParametro = AutorId ?? 0;
            if (AutorId > 0)
            {
                var LivroRelacionalAutor = Mapper.Map<LivroViewModels, Livro>(LivroViewModel);
                _LivroApp.Relacionar(LivroRelacionalAutor, AutorPorParametro);
                return RedirectToAction("Index");
            }
            var livroDomain = Mapper.Map<LivroViewModels, Livro>(LivroViewModel);
            _LivroApp.Add(livroDomain);
            return RedirectToAction("Index");
        }
        // GET: Livro/Edit/5
        public ActionResult Edit(int id)
        {
            var LivroDomain = _LivroApp.GetById(id);
            var LivroVM = Mapper.Map<Livro, LivroViewModels>(LivroDomain);
            ViewBag.GeneroId = new SelectList(_GeneroApp.GetAll(), "GeneroId", "Tipo");
            ViewBag.EditoraId = new SelectList(_EditoraApp.GetAll(), "EditoraId", "Nome");
            return View(LivroVM);
        }

        // POST: Livro/Edit/5
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LivroViewModels lIvroViewModels)
        {
            if (ModelState.IsValid)
            {
                var LivroDomain = Mapper.Map<LivroViewModels, Livro>(lIvroViewModels);
                _LivroApp.Update(LivroDomain);
                return RedirectToAction("Index");
            }
            ViewBag.GeneroId = new SelectList(_GeneroApp.GetAll(), "GeneroId", "Tipo", lIvroViewModels.GeneroId);
            ViewBag.EditoraId = new SelectList(_EditoraApp.GetAll(), "EditoraId", "Nome", lIvroViewModels.EditoraId);
            return View(lIvroViewModels);
        }

        // GET: Livro/Delete/5
        public ActionResult Delete(int id)
        {
            var LivroDomain = _LivroApp.GetById(id);
            var livroVM = Mapper.Map<Livro, LivroViewModels>(LivroDomain);
            ViewBag.GeneroId = new SelectList(_GeneroApp.GetAll(), "GeneroId", "Tipo");
            ViewBag.EditoraId = new SelectList(_EditoraApp.GetAll(), "EditoraId", "Nome");
            return View(livroVM);
        }

        // POST: Livro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Deletar(int Id)
        {
            var livroDomain = _LivroApp.GetById(Id);
            _LivroApp.Remove(livroDomain);
            return RedirectToAction("Index");
        }
    }
}
