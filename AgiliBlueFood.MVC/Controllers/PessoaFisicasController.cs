using AgiliBlueFood.Application.Interface;
using AgiliBlueFood.Domain.Entities;
using AgiliBlueFood.MVC.ViewModels;
using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AgiliBlueFood.MVC.Controllers
{
    public class PessoaFisicasController : Controller
    {
        private readonly IPessoaFisicaAppService _pessoaFisicaApp;

        public PessoaFisicasController(IPessoaFisicaAppService pessoaFisicaApp)
        {
            _pessoaFisicaApp = pessoaFisicaApp;
        }
         
        // GET: PessoaFisicas
        public ActionResult Index()
        {
            var pessoaFisicaViewModel = Mapper.Map<IEnumerable<PessoaFisica>, IEnumerable<PessoaFisicaViewModel>>(_pessoaFisicaApp.GetAll());

            return View(pessoaFisicaViewModel);
        }

        // GET: PessoaFisicas/Details/5
        public ActionResult Details(int id)
        {
            var pessoaDomain = _pessoaFisicaApp.GetById(id);
            var pessoaFisicaViewModel = Mapper.Map<PessoaFisica, PessoaFisicaViewModel>(pessoaDomain);

            return View(pessoaFisicaViewModel);

        }

        // GET: PessoaFisicas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PessoaFisicas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PessoaFisicaViewModel pessoaFisica)
        {
            if (ModelState.IsValid)
            {
                var pessoaDomain = Mapper.Map<PessoaFisicaViewModel, PessoaFisica>(pessoaFisica);
                _pessoaFisicaApp.Add(pessoaDomain);

                return RedirectToAction("Index");
            }


            return View(pessoaFisica);
        }

        // GET: PessoaFisicas/Edit/5
        public ActionResult Edit(int id)
        {
            var pessoaDomain = _pessoaFisicaApp.GetById(id);
            var pessoaViewModel = Mapper.Map<PessoaFisica, PessoaFisicaViewModel>(pessoaDomain);

            return View(pessoaViewModel);

        }

        // POST: PessoaFisicas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PessoaFisicaViewModel pessoaFisica)
        {
            if (ModelState.IsValid)
            {
                var pessoaDomain = Mapper.Map<PessoaFisicaViewModel, PessoaFisica>(pessoaFisica);
                _pessoaFisicaApp.Update(pessoaDomain);

                return RedirectToAction("Index");

            }

            return View(pessoaFisica);
            
        }

        // GET: PessoaFisicas/Delete/5
        public ActionResult Delete(int id)
        {
            var pessoaDomain = _pessoaFisicaApp.GetById(id);
            var pessoaViewModel = Mapper.Map<PessoaFisica, PessoaFisicaViewModel>(pessoaDomain);

            return View(pessoaViewModel);

        }


        // POST: PessoaFisicas/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var pessoaDomain = _pessoaFisicaApp.GetById(id);
            _pessoaFisicaApp.Remove(pessoaDomain);

            return RedirectToAction("Index");
        }
    }
}
