using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UZEM.PROJECT.BLL.Abstract;
using UZEM_PROJECT.Model;

namespace UZEM.PROJECT.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        ICourseService _courseService;
        public HomeController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        public ActionResult Index()
        {
            return View(_courseService.GetAll());
        }
        public ActionResult Index2()
        {
            return View();
        }
        public ActionResult Courses()
        {
            return View();
        }

        public ActionResult HowToCreate()
        {
            return View();
        }

        [HttpGet]
        public ActionResult OpeningPage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult OpeningPage(CourseClass course)
        {
            _courseService.Insert(course);
            return View();
        }

        public ActionResult CoursePlan()
        {
            return View();
        }

        public ActionResult AddingDetails()
        {
            return View();
        }

        public ActionResult SubmitForReview()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveCourse(CourseClass course)
        {
            _courseService.Insert(course);
            return View();
        }

    }
}