using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModels;

namespace SchoolUI.Controllers
{
    public class GovernateController : Controller
    {


        private readonly GovernateService GovernateService;
        
        public GovernateController(GovernateService _GovernateService)
        {
            GovernateService = _GovernateService;
            
        }
        // GET: Home
        public ActionResult Governate()
        {
            if (Session["User"] == null)
                return RedirectToAction("Login", "Home", null);
            var Governates = GovernateService.GetAll().ToList();
            return View(Governates);
        }

        public ActionResult Details(int id)
        {

            if (Session["User"] == null)
                return RedirectToAction("Login", "Home", null);
            GovernateViewModel Governate = GovernateService.GetByID(id);
            return View(Governate);
        }

        public ActionResult Add()
        {
            if (Session["User"] == null)
                return RedirectToAction("Login", "Home", null);
            
            return View();
        }
        [HttpPost]
        public ActionResult Add(GovernateEditViewModel Governate)
        {
            if (!ModelState.IsValid)
            {
               
                return View();
            }

            GovernateService.Add(Governate);
            return RedirectToAction("Governate");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            GovernateService.Remove(id);
            return RedirectToAction("Governate");
        }
        public ActionResult Update(int id)
        {
            if (Session["User"] == null)
                return RedirectToAction("Login", "Home", null);

            var Governate = GovernateService.GetByID(id);
            return View(Governate);
        }
        [HttpPost]
        public ActionResult Update(GovernateEditViewModel Governate)
        {
            if (!ModelState.IsValid)
            {
                
                return View();
            }

            GovernateService.Update(Governate);
            return RedirectToAction("Governate");
        }
    }
}