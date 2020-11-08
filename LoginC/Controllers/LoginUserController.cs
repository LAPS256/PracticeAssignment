using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginC.Models;

namespace LoginC.Controllers
{
    public class LoginUserController : Controller
    {
        // GET: LoginUser
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Signup(Login li)
        {


            return View(li);
        }

        public ActionResult SubmitData(Login li)
        {
            if (ModelState.IsValid)
            {
                Enterintotable en = new Models.Enterintotable();
                en.InsertUser(li);
                ViewBag.name = li.rname;

                // return View();  
                return View("login");
            }
            else
            {
                return View("SignUp");
            }

        }
        public ActionResult login(Login li)
        {
            return View(li);

        }
        public ActionResult Loginsearch(Login li)
        {
            Searchuser ss = new Searchuser();
            string pass = ss.searchk(li);

            if (pass == li.Userpassword)
            {
                return RedirectToAction("Index", "Employee");
               
              

            }
            @ViewBag.data = "invalide user";
            return View();
           

        }

        public ActionResult loadlogin()
        {

            return View();
        }
    }
}