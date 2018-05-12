using AgiliBlueFood.Application.Interface;
using AgiliBlueFood.Domain.Entities;
using AgiliBlueFood.MVC.ViewModels;
using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AgiliBlueFood.MVC.Controllers
{
    public class PessoaJuridicasController : Controller
    {
        private readonly IPessoaJuridicaAppService _pessoaJuridicaApp;

        public PessoaJuridicasController(IPessoaJuridicaAppService pessoaJuridicaApp)
        {
            _pessoaJuridicaApp = pessoaJuridicaApp;
        }

       // private readonly PessoaJuridicaRepository _pessoaJuridicaRepository = new PessoaJuridicaRepository();

        // GET: PessoaJuridicas
        public ActionResult Index()
        {
            var pessoaJuridicaViewModel = Mapper.Map<IEnumerable<PessoaJuridica>, IEnumerable<PessoaJuridicaViewModel>>(_pessoaJuridicaApp.GetAll());
            return View(pessoaJuridicaViewModel);
        }

        // GET: PessoaJuridicas/Details/5
        public ActionResult Details(int id)
        {
            var pessoaJuridica = _pessoaJuridicaApp.GetById(id);
            var pessoaJuridicaViewModel = Mapper.Map<PessoaJuridica, PessoaJuridicaViewModel>(pessoaJuridica);

            return View(pessoaJuridicaViewModel);
        }

        // GET: PessoaJuridicas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PessoaJuridicas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PessoaJuridicaViewModel pessoaJuridica)
        {
            if(ModelState.IsValid)
            {
                var clienteDomain = Mapper.Map<PessoaJuridicaViewModel, PessoaJuridica>(pessoaJuridica);
                _pessoaJuridicaApp.Add(clienteDomain);

                return RedirectToAction("Index");
            }

            return View(pessoaJuridica);
            
        }

        // GET: PessoaJuridicas/Edit/5
        public ActionResult Edit(int id)
        {
            var pessoaJuridica = _pessoaJuridicaApp.GetById(id);
            var pessoaJuridicaViewModel = Mapper.Map<PessoaJuridica, PessoaJuridicaViewModel>(pessoaJuridica);

            return View(pessoaJuridicaViewModel);
        }

        // POST: PessoaJuridicas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PessoaJuridicaViewModel pessoaJuridica)
        {
            if (ModelState.IsValid)
            {
                var pessoaJuridicaDomain = Mapper.Map<PessoaJuridicaViewModel, PessoaJuridica>(pessoaJuridica);
                _pessoaJuridicaApp.Update(pessoaJuridicaDomain);

                return RedirectToAction("Index");
            }

            return View(pessoaJuridica);
        }

        // GET: PessoaJuridicas/Delete/5
        public ActionResult Delete(int id)
        {
            var pessoaJuridica = _pessoaJuridicaApp.GetById(id);
            var pessoaJuridicaViewModel = Mapper.Map<PessoaJuridica, PessoaJuridicaViewModel>(pessoaJuridica);

            return View(pessoaJuridicaViewModel);
        }

        // POST: PessoaJuridicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var pessoaJuridica = _pessoaJuridicaApp.GetById(id);
            _pessoaJuridicaApp.Remove(pessoaJuridica);

            return RedirectToAction("Index");
        }
    }
}
