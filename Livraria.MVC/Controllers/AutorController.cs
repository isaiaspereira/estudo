
using AutoMapper;
using Livraria.Application.Interface;
using Livraria.Domain.Entitis;
using Livraria.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Livraria.MVC.Controllers
{
    public class AutorController : Controller
    {
        private readonly IAutorAppService _AutorApp;
        public AutorController(IAutorAppService autorApp)
        {
            _AutorApp = autorApp;
        }
        // GET: Autor
        public ActionResult Index(string Pesquisa = "")
        {
            if (!string.IsNullOrEmpty(Pesquisa))
            {
                var PesquisaPorNome = _AutorApp.BuscaPorNome(Pesquisa);
                var autorViewModels = Mapper.Map<IEnumerable<Autor>, IEnumerable<AutorViewModels>>(PesquisaPorNome);
                return View(autorViewModels);
            }
            var autorViewModel = Mapper.Map<IEnumerable<Autor>, IEnumerable<AutorViewModels>>(_AutorApp.GetAll());
            return View(autorViewModel);
        }

        // GET: Autor/Details/5
        public ActionResult Details(int id)
        {
            var AutorVM = Mapper.Map<Autor, AutorViewModels>(_AutorApp.GetById(id));
            return View(AutorVM);
        }

        // GET: Autor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Autor/Create
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AutorViewModels AutorVm)
        {
            if (ModelState.IsValid)
            {
                var AutorDomain = Mapper.Map<AutorViewModels, Autor>(AutorVm);
                _AutorApp.Add(AutorDomain);
                return RedirectToAction("Index");
            }
            return View(AutorVm);
        }

        // GET: Autor/Edit/5
        public ActionResult Edit(int id)
        {
            var AutorVm = Mapper.Map<Autor, AutorViewModels>(_AutorApp.GetById(id));
            return View(AutorVm);
        }

        // POST: Autor/Edit/5
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AutorViewModels AutorVm)
        {
            if (ModelState.IsValid)
            {
                var AutorDomain = Mapper.Map<AutorViewModels, Autor>(AutorVm);
                _AutorApp.Update(AutorDomain);
                return RedirectToAction("Index");
            }
            return View(AutorVm);
        }

        // GET: Autor/Delete/5
        public ActionResult Delete(int id)
        {
            var AutorVM = Mapper.Map<Autor, AutorViewModels>(_AutorApp.GetById(id));
            return View(AutorVM);
        }

        // POST: Autor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Deletar(int id)
        {
            var AutorVm = _AutorApp.GetById(id);
            _AutorApp.Remove(AutorVm);
            return RedirectToAction("Index");
        }
    }
}
