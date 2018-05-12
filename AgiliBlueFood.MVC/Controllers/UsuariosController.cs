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
    public class UsuariosController : Controller
    {
        private readonly IUsuarioAppService _usuarioApp;
        private readonly IPessoaFisicaAppService _pessoaFisicaApp;

        public UsuariosController(IUsuarioAppService usuarioApp, IPessoaFisicaAppService pessoaFisicaApp)
        {
            _usuarioApp = usuarioApp;
            _pessoaFisicaApp = pessoaFisicaApp;
        }

        // GET: Usuarios
        public ActionResult Index()
        {
            var usuarioViewModel = Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_usuarioApp.GetAll());

            //var pessoaViewModel = Mapper.Map<IEnumerable<PessoaFisica>, IEnumerable<PessoaFisicaViewModel>>(_pessoaFisicaApp.GetAll());


            ViewBag.PessoaFisicaId = new SelectList(_pessoaFisicaApp.GetAll(), "PessoaFisicaId", "NomePf");

            return View(usuarioViewModel);
        }

        // GET: Usuarios/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Usuarios/Create
        public ActionResult Create()
        {

            ViewBag.PessoaFisicaId = new SelectList(_pessoaFisicaApp.GetAll(), "PessoaFisicaId", "NomePf");

            return View();
        }

        // POST: Usuarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioViewModel usuario)
        {
            if (ModelState.IsValid)
            {
                var usuaurioDomain = Mapper.Map<UsuarioViewModel, Usuario>(usuario);
                _usuarioApp.Add(usuaurioDomain);

                return RedirectToAction("Index");
            }

            ViewBag.PessoaFisicaId = new SelectList(_pessoaFisicaApp.GetAll(), "PessoaFisicaId", "Nome", usuario.PessoaFisicaId);

            return View(usuario);

        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Usuarios/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuarios/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuarios/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
