using AgiliBlueFood.Application.Interface;
using AgiliBlueFood.Domain.Entities;
using AgiliBlueFood.MVC.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgiliBlueFood.MVC.Controllers
{
    public class BairrosController : Controller
    {
        private readonly IBairroAppService _bairroApp;
        private readonly IMunicipioAppService _municipioApp;

        public BairrosController(IBairroAppService bairroApp, IMunicipioAppService municipioApp)
        {
            _bairroApp = bairroApp;
            _municipioApp = municipioApp;
                
        }
        // GET: Bairros
        public ActionResult Index()
        {
            var bairroViewModel = Mapper.Map<IEnumerable<Bairro>, IEnumerable<BairroViewModel>>(_bairroApp.GetAll());
            return View(bairroViewModel);
        }

        // GET: Bairros/Details/5
        public ActionResult Details(int id)
        {
            var bairro = _bairroApp.GetById(id);
            var bairroViewModel = Mapper.Map<Bairro, BairroViewModel>(bairro);

            return View(bairroViewModel);
        }

        // GET: Bairros/Create
        public ActionResult Create()
        {
            ViewBag.MunicipioId = new SelectList(_municipioApp.GetAll(), "MunicipioId", "NomeMunicipio");

            return View();
        }

        // POST: Bairros/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BairroViewModel bairro)
        {
            if(ModelState.IsValid)
            {
                var bairroDomain = Mapper.Map<BairroViewModel, Bairro>(bairro);
                _bairroApp.Add(bairroDomain);

                return RedirectToAction("Index");
            }

            ViewBag.MunicipioId = new SelectList(_municipioApp.GetAll(), "MunicipioId", "NomeMunicipio", bairro.MunicipioId);

            return View(bairro);
        }

        // GET: Bairros/Edit/5
        public ActionResult Edit(int id)
        {
            var bairro = _bairroApp.GetById(id);
            var bairroViewModel = Mapper.Map<Bairro, BairroViewModel>(bairro);

            ViewBag.MunicipioId = new SelectList(_municipioApp.GetAll(), "MunicipioId", "NomeMunicipio", bairroViewModel.MunicipioId);

            return View(bairroViewModel);
        }

        // POST: Bairros/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BairroViewModel bairro)
        {
            if(ModelState.IsValid)
            {
                var bairroDomain = Mapper.Map<BairroViewModel, Bairro>(bairro);
                _bairroApp.Update(bairroDomain);

                return RedirectToAction("Index");
            }

            ViewBag.MunicipioId = new SelectList(_municipioApp.GetAll(), "MunicipioId", "NomeMunicipio", bairro.MunicipioId);

            return View(bairro);
        }

        // GET: Bairros/Delete/5
        public ActionResult Delete(int id)
        {
            var bairro = _bairroApp.GetById(id);
            var bairroViewModel = Mapper.Map<Bairro, BairroViewModel>(bairro);

            return View(bairroViewModel);
        }

        // POST: Bairros/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmned(int id)
        {
            var bairro = _bairroApp.GetById(id);
            _bairroApp.Remove(bairro);

            return RedirectToAction("Index");
        }
    }
}
