using AgiliBlueFood.Application.Interface;
using AgiliBlueFood.Domain.Entities;
using AgiliBlueFood.MVC.ViewModels;
using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AgiliBlueFood.MVC.Controllers
{
    public class MunicipiosController : Controller
    {
        private readonly IMunicipioAppService _municipioApp;
        private readonly IEstadoAppService _estadoApp;

        public MunicipiosController(IMunicipioAppService municipioApp, IEstadoAppService estadoApp)
        {
            _municipioApp = municipioApp;
            _estadoApp = estadoApp;
        }


        // GET: Municipio
        public ActionResult Index()
        {
            var municipioViewModel = Mapper.Map<IEnumerable<Municipio>, IEnumerable<MunicipioViewModel>>(_municipioApp.GetAll());
            return View(municipioViewModel);

        }

        // GET: Municipio/Details/5
        public ActionResult Details(int id)
        {
            var municipio = _municipioApp.GetById(id);
            var municipioViewModel = Mapper.Map<Municipio, MunicipioViewModel>(municipio);

            return View(municipioViewModel);
        }

        // GET: Municipio/Create
        public ActionResult Create()
        {
            ViewBag.EstadoId = new SelectList(_estadoApp.GetAll(), "EstadoId", "NomeEstado");

            return View();
        }

        // POST: Municipio/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MunicipioViewModel municipio)
        {
            if (ModelState.IsValid)
            {
                var municipioDomain = Mapper.Map<MunicipioViewModel, Municipio>(municipio);
                _municipioApp.Add(municipioDomain);

                return RedirectToAction("Index");
            }

            ViewBag.EstadoId = new SelectList(_estadoApp.GetAll(), "EstadoId", "NomeEstado", municipio.EstadoId);

            return View(municipio);

        }

        // GET: Municipio/Edit/5
        public ActionResult Edit(int id)
        {
            var municipio = _municipioApp.GetById(id);
            var municipioViewModel = Mapper.Map<Municipio, MunicipioViewModel>(municipio);

            ViewBag.EstadoId = new SelectList(_estadoApp.GetAll(), "EstadoId", "NomeEstado", municipioViewModel.EstadoId);


            return View(municipioViewModel);
        }

        // POST: Municipio/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MunicipioViewModel municipio)
        {
            if (ModelState.IsValid)
            {
                var municipioDomain = Mapper.Map<MunicipioViewModel, Municipio>(municipio);
                _municipioApp.Update(municipioDomain);

                return RedirectToAction("Index");
            }

            ViewBag.EstadoId = new SelectList(_estadoApp.GetAll(), "EstadoId", "NomeEstado", municipio.EstadoId);

            return View(municipio);
        }

        // GET: Municipio/Delete/5
        public ActionResult Delete(int id)
        {
            var municipio = _municipioApp.GetById(id);
            var municipioViewModel = Mapper.Map<Municipio, MunicipioViewModel>(municipio);

            return View(municipioViewModel);
        }

        // POST: Municipio/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var municipio = _municipioApp.GetById(id);
            _municipioApp.Remove(municipio);

            return RedirectToAction("Index");
        }
    }
}
