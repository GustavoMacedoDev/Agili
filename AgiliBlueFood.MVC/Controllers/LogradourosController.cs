using AgiliBlueFood.Application.Interface;
using AgiliBlueFood.Domain.Entities;
using AgiliBlueFood.MVC.ViewModels;
using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AgiliBlueFood.MVC.Controllers
{
    public class LogradourosController : Controller
    {
        private readonly ILogradouroAppService _logradouroApp;
        private readonly ITipoLogradouroAppService _tipoLogradouroApp;
        private readonly IMunicipioAppService _municipioApp;
        private readonly IEstadoAppService _estadoApp;
        private readonly IPaisAppService _paisApp;

        public LogradourosController(ILogradouroAppService logradouroApp, ITipoLogradouroAppService tipoLogradouroApp, IMunicipioAppService municipioApp, IEstadoAppService estadoApp, IPaisAppService paisApp)
        {
            _logradouroApp = logradouroApp;
            _tipoLogradouroApp = tipoLogradouroApp;
            _municipioApp = municipioApp;
            _estadoApp = estadoApp;
            _paisApp = paisApp;
        }

        // GET: Logradouros
        public ActionResult Index()
        {
            var logradouroViewModel =  Mapper.Map<IEnumerable<Logradouro>, IEnumerable<LogradouroViewModel>>(_logradouroApp.GetAll());

            return View(logradouroViewModel);

        }

            // GET: Logradouros/Details/5
        public ActionResult Details(int id)
        {
            var logradouro = _logradouroApp.GetById(id);
            var logradouroViewModel = Mapper.Map<Logradouro, LogradouroViewModel>(logradouro);

            return PartialView(logradouroViewModel);
        }

        // GET: Logradouros/Create
        public ActionResult Create()
        {
            ViewBag.PaisId = new SelectList(_paisApp.GetAll(), "PaisId", "NomePais");
            ViewBag.EstadoId = new SelectList(_estadoApp.GetAll(), "EstadoId", "NomeEstado");
            ViewBag.MunicipioId = new SelectList(_municipioApp.GetAll(), "MunicipioId", "NomeMunicipio");
            ViewBag.TipoLogradouroId = new SelectList(_tipoLogradouroApp.GetAll(), "TipoLogradouroId", "TipodoLogradouro");


            return View();
        }

        // POST: Logradouros/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LogradouroViewModel logradouro)
        {
            if(ModelState.IsValid)
            {
                var logradouroDomain = Mapper.Map<LogradouroViewModel, Logradouro>(logradouro);

                _logradouroApp.Add(logradouroDomain);

                return RedirectToAction("Index");
            }

            ViewBag.PaisId = new SelectList(_paisApp.GetAll(), "PaisId", "NomePais", logradouro.PaisId);
            ViewBag.EstadoId = new SelectList(_estadoApp.GetAll(), "EstadoId", "NomeEstado", logradouro.EstadoId);
            ViewBag.MunicipioId = new SelectList(_municipioApp.GetAll(), "MunicipioId", "NomeMunicipio", logradouro.MunicipioId);
            ViewBag.TipoLogradouroId = new SelectList(_tipoLogradouroApp.GetAll(), "TipoLogradouroId", "TipoDoLogradouro", logradouro.TipoLogradouroId);


            return View(logradouro);
        }

        // GET: Logradouros/Edit/5
        public ActionResult Edit(int id)
        {
            var logradouro = _logradouroApp.GetById(id);
            var logradouroViewModel = Mapper.Map<Logradouro, LogradouroViewModel>(logradouro);

            ViewBag.PaisId = new SelectList(_paisApp.GetAll(), "PaisId", "NomePais", logradouroViewModel.PaisId);
            ViewBag.EstadoId = new SelectList(_estadoApp.GetAll(), "EStadoId", "NomeEstado", logradouroViewModel.EstadoId);
            ViewBag.MunicipioId = new SelectList(_municipioApp.GetAll(), "MunicipioId", "NomeMunicipio", logradouroViewModel.MunicipioId);
            ViewBag.TipoLogradouroId = new SelectList(_tipoLogradouroApp.GetAll(), "TipoLogradouroId", "TipoDoLogradouro", logradouroViewModel.TipoLogradouroId);


            return View(logradouroViewModel);
        }

        // POST: Logradouros/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LogradouroViewModel logradouro)
        {
            if(ModelState.IsValid)
            {
                var logradouroDomain = Mapper.Map<LogradouroViewModel, Logradouro>(logradouro);
                _logradouroApp.Update(logradouroDomain);

                return RedirectToAction("Index");
            }

            ViewBag.PaisId = new SelectList(_paisApp.GetAll(), "PaisId", "NomePais", logradouro.PaisId);
            ViewBag.EstadoId = new SelectList(_estadoApp.GetAll(), "EstadoId", "NomeEstado", logradouro.EstadoId);
            ViewBag.MunicipioId = new SelectList(_municipioApp.GetAll(), "MunicipioId", "NomeMunicipio", logradouro.MunicipioId);
            ViewBag.TipoLogradouroId = new SelectList(_tipoLogradouroApp.GetAll(), "TipoLogradouroId", "TipodoLogradouro", logradouro.TipoLogradouroId);


            return View(logradouro);
        }

        // GET: Logradouros/Delete/5
        public ActionResult Delete(int id)
        {
            var logradouro = _logradouroApp.GetById(id);
            var logradouroViewModel = Mapper.Map<Logradouro, LogradouroViewModel>(logradouro);

            return View(logradouroViewModel);
        }

        // POST: Logradouros/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var logradouro = _logradouroApp.GetById(id);
            _logradouroApp.Update(logradouro);

            return RedirectToAction("Index");
        }
    }
}
