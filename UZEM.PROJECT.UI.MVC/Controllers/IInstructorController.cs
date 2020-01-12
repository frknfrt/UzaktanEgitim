using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UZEM.PROJECT.BLL.Abstract;
using UZEM.PROJECT.UI.MVC.Tools;
using UZEM_PROJECT.Model;

namespace UZEM.PROJECT.UI.MVC.Controllers
{
    public class IInstructorController : Controller
    {
        IUserService _userService;
        IInstructorService _ınstructorService;

        public IInstructorController(IUserService userService,IInstructorService ınstructorService)
        {
            _userService = userService;
            _ınstructorService = ınstructorService;
        }

        [HttpGet]
        public ActionResult EgitmenBasvuru()
        {

            return View();

        }

        [HttpPost]
        public ActionResult EgitmenBasvuru(InstructorClass ınstructor)
        {
            if (!ModelState.IsValid)
            {
                return View("EgitmenBasvuru");

            }
            _ınstructorService.Insert(ınstructor);

            return View();
    

        }
        [HttpGet]
        public ActionResult EgitmenEkle()
        {

            UserClass user = Session["Kullanici"] as UserClass;
            var userID = user.ID;
            return View(_userService.Get(userID));


        }
        [HttpPost]
        public ActionResult EgitmenEkle(InstructorClass ınstructor)
        {
            if (!ModelState.IsValid)
            {
                return View("EgitmenEkle");

            }
            _ınstructorService.Insert(ınstructor);
    
      
            return RedirectToAction("Index","Home");


        }

        public ActionResult EgitmenProfili()
        {

            return View();
        }

        public ActionResult KartBilgileri()
        {
            return View();

        }
        public ActionResult Kurs()
        {
            return View();
        
        }

        public ActionResult Hesap()
        {
            return View();

        }


    }
}