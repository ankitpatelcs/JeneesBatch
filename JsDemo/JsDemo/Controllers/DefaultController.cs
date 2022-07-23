using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JsDemo.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult jq()
        {
            return View();
        }
        public ActionResult dtpicker()
        {
            return View();
        }
        public ActionResult novis()
        {
            return View();
        }
    }
}