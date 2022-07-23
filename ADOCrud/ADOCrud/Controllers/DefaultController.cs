using ADOCrud.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADOCrud.Controllers
{
    public class DefaultController : Controller
    {
        CompanyService dc = new CompanyService();
        // GET: Default
        public ActionResult Index()
        {
            return View(dc.GetEmployees());
        }

        public ActionResult Details(int id)
        {
            return View(dc.GetEmployeeByID(id));
        }
    }
}