using ADOCrud.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ADOCrud.Models;

namespace ADOCrud.Controllers
{
    public class DefaultController : Controller
    {
        ICompanyService dc = new CompanyService();
        // GET: Default
        public ActionResult Index()
        {
            return View(dc.GetEmployees());
        }

        public ActionResult Details(int id)
        {
            return View(dc.GetEmployeeByID(id));
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tblemployee obj)
        {
            dc.AddEmployee(obj);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            return View(dc.GetEmployeeByID(id));
        }
        [HttpPost]
        public ActionResult Edit(tblemployee obj)
        {
            dc.UpdateEmployee(obj);
            return RedirectToAction("Index");
        }
        
        public ActionResult Delete(int id)
        {
            return View(dc.GetEmployeeByID(id));
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteRec(int id)
        {
            dc.DeleteEmployee(id);
            return RedirectToAction("Index");
        }
    }
}