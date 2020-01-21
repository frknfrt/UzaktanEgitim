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
      

        public IInstructorController(IUserService userService)
        {
            _userService = userService;
           
        }

        [HttpGet]
        public ActionResult EgitmenBasvuru()
        {

            return View();

        }

        [HttpPost]
        public ActionResult EgitmenBasvuru(UserClass user)
        {
            if (!ModelState.IsValid)
            {
                return View("EgitmenBasvuru");

            }


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
        public ActionResult EgitmenEkle(UserClass user)
        {
            if (!ModelState.IsValid)
            {
                return View("EgitmenEkle");

            }
           
    
      
            return RedirectToAction("Index","Home");


        }
        [HttpGet]
        public ActionResult EgitmenProfili(UserClass user)
        {
            return View();


        }

        [HttpPost]
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