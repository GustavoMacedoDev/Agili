using AgiliBlueFood.Application.Interface;
using AgiliBlueFood.Domain.Entities;
using AgiliBlueFood.MVC.ViewModels;
using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AgiliBlueFood.MVC.Controllers
{
    public class EstadosController : Controller
    {

        private readonly IEstadoAppService _estadoApp;
        private readonly IPaisAppService _paisApp;

        public EstadosController(IEstadoAppService estadoApp, IPaisAppService paisApp)
        {
            _estadoApp = estadoApp;
            _paisApp = paisApp;

        }

        // GET: Estados
        public ActionResult Index()
        {
            var estadoViewModel = Mapper.Map<IEnumerable<Estado>, IEnumerable<EstadoViewModel>>(_estadoApp.GetAll());
            return View(estadoViewModel);

        }

        // GET: Estados/Details/5
        public ActionResult Details(int id)
        {
            var estado = _estadoApp.GetById(id);
            var estadoViewModel = Mapper.Map<Estado, EstadoViewModel>(estado);

            return View(estadoViewModel);
        }

        // GET: Estados/Create
        public ActionResult Create()
        {
            ViewBag.PaisId = new SelectList(_paisApp.GetAll(), "PaisId", "NomePais");

            return View();
        }

        // POST: Estados/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EstadoViewModel estado)
        {
            if (ModelState.IsValid)
            {
                var estadoDomain = Mapper.Map<EstadoViewModel, Estado>(estado);
                _estadoApp.Add(estadoDomain);

                return RedirectToAction("Index");
            }

            ViewBag.PaisId = new SelectList(_paisApp.GetAll(), "PaisId", "NomePais", estado.PaisId);

            return View(estado);
        }

        // GET: Estados/Edit/5
        public ActionResult Edit(int id)
        {
            var estado = _estadoApp.GetById(id);
            var estadoViewModel = Mapper.Map<Estado, EstadoViewModel>(estado);

            ViewBag.PaisId = new SelectList(_paisApp.GetAll(), "PaisId", "NomePais", estadoViewModel.PaisId);

            return View(estadoViewModel);

        }

        // POST: Estados/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EstadoViewModel estado)
        {
            if(ModelState.IsValid)
            {
                var estadoDomain = Mapper.Map<EstadoViewModel, Estado>(estado);
                _estadoApp.Update(estadoDomain);

                return RedirectToAction("Index");
            }

            ViewBag.PaisId = new SelectList(_paisApp.GetAll(), "PaisId", "NomePais", estado.PaisId);

            return View(estado);
            
        }

        // GET: Estados/Delete/5
        public ActionResult Delete(int id)
        {
            var estado = _estadoApp.GetById(id);
            var estadoViewModel = Mapper.Map<Estado, EstadoViewModel>(estado);

            return View(estadoViewModel);
        }

        // POST: Estados/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var estado = _estadoApp.GetById(id);
            _estadoApp.Remove(estado);

            return RedirectToAction("Index");

        }
    }
}
