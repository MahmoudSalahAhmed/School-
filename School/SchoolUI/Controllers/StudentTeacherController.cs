using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModels;

namespace SchoolUI.Controllers
{
    public class StudentTeacherController : Controller
    {


        private readonly StudentTeacherService StudentTeacherService;
        private readonly TeacherService TeacherService;

        public StudentTeacherController(
            StudentTeacherService _StudentTeacherService,
            TeacherService _TeacherService
            )
        {
            StudentTeacherService = _StudentTeacherService;
            TeacherService = _TeacherService;
        }
        // GET: Home
        public ActionResult StudentTeacher()
        {
            if (Session["User"] == null)
                return RedirectToAction("Login", "Home", null);
            var StudentTeachers = StudentTeacherService.GetAll().ToList();
            return View(StudentTeachers);
        }

        public ActionResult Details(int id)
        {

            if (Session["User"] == null)
                return RedirectToAction("Login", "Home", null);
            StudentTeacherViewModel StudentTeacher = StudentTeacherService.GetByID(id);
            return View(StudentTeacher);
        }

        public ActionResult Add(int id)
        {
            if (Session["User"] == null)
                return RedirectToAction("Login", "Home", null);
            Session["StudentID"] = id;
            ViewBag.StuID = id;
            ViewBag.Teachers = TeacherService.GetAll();
            return View();
        }
        [HttpPost]
        public ActionResult Add(StudentTeacherEditViewModel StudentTeacher)
        {
            if (!ModelState.IsValid)
            {
               
                return View();
            }

            ViewBag.Teachers = TeacherService.GetAll();
            StudentTeacher.StudentID = (int)Session["StudentID"];
            StudentTeacherService.Add(StudentTeacher);
            return RedirectToAction("Details", "Student", new { id = StudentTeacher.StudentID });
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var stuTeacher = StudentTeacherService.GetByID(id);
            StudentTeacherService.Remove(id);
            return RedirectToAction("Details", "Student", new { id = stuTeacher.StudentID });
        }
        public ActionResult Update(int id)
        {
            if (Session["User"] == null)
                return RedirectToAction("Login", "Home", null);
            var StudentTeacher = StudentTeacherService.GetByID(id);
            Session["StudentID"] = StudentTeacher.StudentID;
            ViewBag.Teachers = TeacherService.GetAll();
            return View(StudentTeacher);
        }
        [HttpPost]
        public ActionResult Update(StudentTeacherEditViewModel StudentTeacher)
        {
            if (!ModelState.IsValid)
            {
                
                return View();
            }
            StudentTeacher.StudentID = (int)Session["StudentID"];
            StudentTeacherService.Update(StudentTeacher);
            return RedirectToAction("Details","Student", new {id =  StudentTeacher.StudentID });
        }
    }
}