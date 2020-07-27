using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModels;

namespace SchoolUI.Controllers
{
    public class NeighborhoodController : Controller
    {


        private readonly NeighborhoodService NeighborhoodService;
        private readonly GovernateService GovernateService;

        public NeighborhoodController(NeighborhoodService neighborhoodService, GovernateService governateService)
        {
            NeighborhoodService = neighborhoodService;
            GovernateService = governateService;
        }
        // GET: Home
        public ActionResult Neighborhood()
        {
            if (Session["User"] == null)
                return RedirectToAction("Login", "Home", null);

            var Neighborhoods = NeighborhoodService.GetAll().ToList();
            return View(Neighborhoods);
        }

        public ActionResult Details(int id)
        {

            if (Session["User"] == null)
                return RedirectToAction("Login", "Home", null);
            
            NeighborhoodViewModel Neighborhood = NeighborhoodService.GetByID(id);
            return View(Neighborhood);
        }

        public ActionResult Add()
        {
            if (Session["User"] == null)
                return RedirectToAction("Login", "Home", null);
            ViewBag.Governates = GovernateService.GetAll();
            return View();
        }
        [HttpPost]
        public ActionResult Add(NeighborhoodEditViewModel Neighborhood)
        {
            if (!ModelState.IsValid)
            {
               
                return View();
            }
            NeighborhoodService.Add(Neighborhood);
            return RedirectToAction("Neighborhood");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            NeighborhoodService.Remove(id);
            return RedirectToAction("Neighborhood");
        }
        public ActionResult Update(int id)
        {
            if (Session["User"] == null)
                return RedirectToAction("Login", "Home", null);

            ViewBag.Governates = GovernateService.GetAll();
            var Neighborhood = NeighborhoodService.GetByID(id);
            return View(Neighborhood);
        }
        [HttpPost]
        public ActionResult Update(NeighborhoodEditViewModel Neighborhood)
        {
            if (!ModelState.IsValid)
            {
                
                return View();
            }

            NeighborhoodService.Update(Neighborhood);
            return RedirectToAction("Neighborhood");
        }
    }
}