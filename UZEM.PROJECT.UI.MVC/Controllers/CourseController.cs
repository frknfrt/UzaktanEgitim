using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UZEM.PROJECT.BLL.Abstract;
using UZEM.PROJECT.BLL.Concrete;

namespace UZEM.PROJECT.UI.MVC.Controllers
{
    public class CourseController : Controller
    {
        ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        public ActionResult Courses()
        {
            return View(_courseService.GetAll().ToList());
        }
    }
}