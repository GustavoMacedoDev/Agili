using AgiliBlueFood.Application.Interface;
using AgiliBlueFood.Domain.Entities;
using AgiliBlueFood.MVC.ViewModels;
using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AgiliBlueFood.MVC.Controllers
{
    public class LoginsController : Controller
    {
        private readonly ILoginAppService _loginApp;

        public LoginsController(ILoginAppService loginApp)
        {
            _loginApp = loginApp;

        }

        // GET: Login
        public ActionResult Index()
        {
            var loginViewModel = Mapper.Map<IEnumerable<Login>, IEnumerable<LoginViewModel>>(_loginApp.GetAll());
            return View(loginViewModel);
        }

        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            var login = _loginApp.GetById(id);
            var loginViewModel = Mapper.Map<Login, LoginViewModel>(login);

            return View(loginViewModel);
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                var loginDomain = Mapper.Map<LoginViewModel, Login>(login);
                _loginApp.Add(loginDomain);

                return RedirectToAction("Index");
            }

            return View(login);
        }

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            var login = _loginApp.GetById(id);
            var loginViewModel = Mapper.Map<Login, LoginViewModel>(login);

            return View(loginViewModel);
        }

        // POST: Login/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                var loginDomain = Mapper.Map<LoginViewModel, Login>(login);
                _loginApp.Update(loginDomain);

                return RedirectToAction("Index");
            }

            return View(login);
        }

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            var login = _loginApp.GetById(id);
            var loginViewModel = Mapper.Map<Login, LoginViewModel>(login);

            return View(loginViewModel);
        }

        // POST: Login/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var login = _loginApp.GetById(id);
            _loginApp.Remove(login);

            return RedirectToAction("Index");
        }
    }
}
