
using AutoMapper;
using Livraria.Application.Interface;
using Livraria.Domain.Entitis;
using Livraria.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Livraria.MVC.Controllers
{
    public class EditoraController : Controller
    {
        private readonly IEditoraAppService _EditoraApp;
        private readonly IAutorAppService _AutorApp;
        public EditoraController(IEditoraAppService editoraApp, IAutorAppService autorApp)
        {
            _EditoraApp = editoraApp;
            _AutorApp = autorApp;
        }
        // GET: Editora
        public ActionResult Index(string Pesquisa = "")
        {

                if (!string.IsNullOrEmpty(Pesquisa))
                {
                    var PesquisaPorNome = _EditoraApp.BuscaPorNome(Pesquisa);
                    var editoraViewModels = Mapper.Map<IEnumerable<Editora>, IEnumerable<EditoraViewModels>>(PesquisaPorNome);
                    return View(editoraViewModels);
                }
            try
            {
                
                var edidoraVM = Mapper.Map<IEnumerable<Editora>, IEnumerable<EditoraViewModels>>(_EditoraApp.GetAll());

                return View(edidoraVM);
            }
            catch (System.StackOverflowException erro)
            {

                ViewBag.detalheDoErro = (erro.ToString());
                return View("Error");
            }

        }

        // GET: Editora/Details/5
        public ActionResult Details(int id)
        {
            var EditoraVm = Mapper.Map<Editora, EditoraViewModels>(_EditoraApp.GetById(id));
            return View(EditoraVm);
        }

        // GET: Editora/Create
        public ActionResult Create()
        {
            ViewBag.Autores = new SelectList(_AutorApp.GetAll(), "AutorId", "Nome", "AutorId");
            return View();
        }

        // POST: Editora/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EditoraViewModels EditoraVm, int Autores)
        {

            try
            {
                var EditoraParaDomain = Mapper.Map<EditoraViewModels, Editora>(EditoraVm);
                if (Autores >= 0)
                {
                    _EditoraApp.Relacionar(EditoraParaDomain, Autores);
                    return RedirectToAction("Index");

                }
                _EditoraApp.Add(EditoraParaDomain);
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Autores = new SelectList(_AutorApp.GetAll(), "AutorId", "Nome", EditoraVm.Autores);
                return View(EditoraVm);
            }
        }

        // GET: Editora/Edit/5
        public ActionResult Edit(int id)
        {
            var EditoraVM = Mapper.Map<Editora, EditoraViewModels>(_EditoraApp.GetById(id));
            return View(EditoraVM);
        }

        // POST: Editora/Edit/5
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(EditoraViewModels EditoraVm)
        {
            var EditoraDomain = Mapper.Map<EditoraViewModels, Editora>(EditoraVm);
            _EditoraApp.Update(EditoraDomain);
            return RedirectToAction("Index");
        }

        // GET: Editora/Delete/5
        public ActionResult Delete(int id)
        {
            _EditoraApp.GetById(id);
            var EditoraVm = Mapper.Map<Editora, EditoraViewModels>(_EditoraApp.GetById(id));
            return View(EditoraVm);
        }

        // POST: Editora/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Deletar(int Id)
        {
            var EditoraVM = _EditoraApp.GetById(Id);
            _EditoraApp.Remove(EditoraVM);
            return RedirectToAction("Index");
        }
    }
}
