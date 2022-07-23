using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StateManagement.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection fc)
        {
            string uname = fc["txtuname"];
            string pass = fc["txtpass"];

            if (uname == "parth" && pass == "p123")
            {
                HttpCookie couname = new HttpCookie("uname");
                couname.Expires = DateTime.Now.AddDays(2);  // for persistant cookies
                couname.Value = uname;
                Response.Cookies.Add(couname);

                HttpCookie copass = new HttpCookie("pass");
                copass.Expires = DateTime.Now.AddDays(2);
                copass.Value = pass;
                Response.Cookies.Add(copass);
            }
            return View();
        }
        public ActionResult QueryString()
        {
            return View();
        }
        public ActionResult GetQ(string fname, string mobile)
        {
            ViewBag.fname = fname;
            ViewBag.mobile = mobile;
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            string uname = fc["txtuname"];
            string pass = fc["txtpass"];

            if (uname == "parth" && pass == "p123")
            {
                //cookie
                Session["uname"] = uname;
                Session["pass"] = pass;
                Session.Timeout = 30;
                return RedirectToAction("HomePage");
            }
            else
            {
                ViewBag.loginerror = "Invalid Username or Password.!";
            }
            return View();
        }

        public ActionResult HomePage()
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login");
        }

        public ActionResult svar()
        {
            ViewData["info"] = "Writing info to View Data";
            ViewBag.msg = "Writing message to View Bag";
            TempData["data"] = "Displaying data from Temp Data";
            return View();
        }

        public ActionResult Second()
        {
            return View();
        }
    }
}