using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModels;

namespace SchoolUI.Controllers
{
    public class StudentController : Controller
    {


        private readonly StudentService StudentService;
        private readonly GovernateService GovernateService;
        private readonly NeighborhoodService NeighborhoodService;
        private readonly FieldService FieldService;

        private readonly StudentTeacherService StudentTeacherService;

        public StudentController(
            StudentService _StudentService,
            StudentTeacherService _StudentTeacherService,
            GovernateService _GovernateService,
            NeighborhoodService _NeighborhoodService,
            FieldService _FieldService
            )
        {
            StudentService = _StudentService;
            StudentTeacherService = _StudentTeacherService;
            GovernateService = _GovernateService;
            NeighborhoodService = _NeighborhoodService;
            FieldService = _FieldService;
        }
        // GET: Home
        public ActionResult Student()
        {
            if (Session["User"] == null)
                return RedirectToAction("Login", "Home", null);
            var Students = StudentService.GetAll().ToList();
            return View(Students);
        }

        public ActionResult Details(int id)
        {

            if (Session["User"] == null)
                return RedirectToAction("Login", "Home", null);
            StudentViewModel Student = StudentService.GetByID(id);
            return View(Student);
        }

        public ActionResult Add()
        {
            if (Session["User"] == null)
                return RedirectToAction("Login", "Home", null);

            ViewBag.Governates = GovernateService.GetAll();
            ViewBag.Neighborhoods = NeighborhoodService.GetAll();
            ViewBag.Fields = FieldService.GetAll();
            return View();
        }
        [HttpPost]
        public ActionResult Add(StudentEditViewModel Student)
        {
            if (!ModelState.IsValid)
            {
               
                return View();
            }

            StudentService.Add(Student);
            return RedirectToAction("Student");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            StudentService.Remove(id);
            return RedirectToAction("Student");
        }
        public ActionResult Update(int id)
        {
            if (Session["User"] == null)
                return RedirectToAction("Login", "Home", null);
            var Student = StudentService.GetByID(id);
            ViewBag.Governates = GovernateService.GetAll();
            ViewBag.Neighborhoods = NeighborhoodService.GetAll();
            ViewBag.Fields = FieldService.GetAll();
            return View(Student);
        }
        [HttpPost]
        public ActionResult Update(StudentEditViewModel Student)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            StudentService.Update(Student);
            return RedirectToAction("Student");
        }
    }
}