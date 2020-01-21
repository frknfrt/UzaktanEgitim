using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using UZEM.PROJECT.BLL.Abstract;
using UZEM.PROJECT.UI.MVC.Tools;
using UZEM_PROJECT.Model;

namespace UZEM.PROJECT.UI.MVC.Controllers
{
    public class AccountController : Controller
    { //contol
        IUserService _userService;        
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserClass user)
        {
            var gelenKullanici = _userService.GetUserByLogin(user.Email, user.Password);
            if (gelenKullanici != null)
            {
                Session["Kullanici"] = gelenKullanici;
                return RedirectToAction("Index", "Home",gelenKullanici.ID);
            }
            ViewBag.Error = "Kullanıcı bulunamadı";
            
           ModelState.AddModelError("", "Yanlış kullanıcı adı veya parola");
           
                return View();
        }



        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(UserClass user)
        {
            try
            {
                _userService.Insert(user);
                bool sonuc = MailHelper.SendConfirmationMail(user.FirstName, user.LastName, user.Password, user.Email, user.ID, user.Role);
                if (!sonuc)
                {
                    return View();
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Veritabanına ekleme hatası";
                return View();
            }
            return RedirectToAction("Login", "Account");
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Logout()
        {
            Session.Clear();
            //FormsAuthentication.SignOut();
            return RedirectToAction("Index2", "Home");
        }
    }
}