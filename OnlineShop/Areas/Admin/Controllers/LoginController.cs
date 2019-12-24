using Model.Lib;
using OnlineShop.Areas.Admin.Models;
using OnlineShop.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var lib = new UserLib();
                var result = lib.Login(model.Username, Encryptor.MD5Hash(model.Password));
                if (result == 1)
                {
                    var user = lib.GetById(model.Username);
                    var userSession = new UserLogin();
                    userSession.UserName = user.UserName;
                    userSession.UserID = user.ID;
                    Session.Add(CommonConstants.USER_SESSION, userSession);
                    return RedirectToAction("Index", "Home");
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "The account doesn not exist.");
                }
                else if (result == -1)
                {
                    ModelState.AddModelError("", "The account has been locked.");
                }
                else if (result == -1)
                {
                    ModelState.AddModelError("", "The account has been locked.");
                }
                else if (result == -2)
                {
                    ModelState.AddModelError("", "The password is incorrect.");
                }
                else
                {
                    ModelState.AddModelError("", "Login fail.");
                }
            }  
               
                return View("Index");

        }
            

        
    }
}