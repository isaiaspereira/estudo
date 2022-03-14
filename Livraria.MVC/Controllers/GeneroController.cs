
using AutoMapper;
using Livraria.Application.Interface;
using Livraria.Domain.Entitis;
using Livraria.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Livraria.MVC.Controllers
{
    public class GeneroController : Controller
    {
        private readonly IGeneroAppService _GeneroApp;
        public GeneroController(IGeneroAppService generoApp)
        {
            _GeneroApp = generoApp;
        }
        // GET: Genero
        public ActionResult Index()
        {
            var GeneroVM = Mapper.Map<IEnumerable<Genero>, IEnumerable<GeneroViewModels>>(_GeneroApp.GetAll());
            return View(GeneroVM);
        }

        // GET: Genero/Details/5
        public ActionResult Details(int id)
        {
            var generoVM = Mapper.Map<Genero, GeneroViewModels>(_GeneroApp.GetById(id));
            return View(generoVM);
        }

        // GET: Genero/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Genero/Create
        [HttpPost, ActionName("Create")]
        public ActionResult Create(GeneroViewModels generoViewModels)
        {
            if (ModelState.IsValid)
            {
                var GeneroDomain = Mapper.Map<GeneroViewModels, Genero>(generoViewModels);
                _GeneroApp.Add(GeneroDomain);
                return RedirectToAction("Index");
            }
            return View(generoViewModels);
        }

        // GET: Genero/Edit/5
        public ActionResult Edit(int id)
        {
            var GeneroVm = Mapper.Map<Genero, GeneroViewModels>(_GeneroApp.GetById(id));
            return View(GeneroVm);
        }

        // POST: Genero/Edit/5
        [HttpPost, ActionName("Edit")]
        public ActionResult Edit(GeneroViewModels generoViewModels)
        {
            if (ModelState.IsValid)
            {
                var GeneroDoamin = Mapper.Map<GeneroViewModels, Genero>(generoViewModels);
                _GeneroApp.Update(GeneroDoamin);
                return RedirectToAction("Index");
            }
            return View(generoViewModels);
        }

        // GET: Genero/Delete/5
        public ActionResult Delete(int id)
        {
            var GeneroVm = Mapper.Map<Genero, GeneroViewModels>(_GeneroApp.GetById(id));
            return View(GeneroVm);
        }

        // POST: Genero/Delete/5
        [HttpPost,ActionName("Delete")]
        public ActionResult Deletetar(int id)
        {
            var genero = _GeneroApp.GetById(id);
            _GeneroApp.Remove(genero);
            return RedirectToAction("Index");
        }
    }
}
