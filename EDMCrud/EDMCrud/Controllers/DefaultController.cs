using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EDMCrud.EDM;

namespace EDMCrud.Controllers
{
    public class DefaultController : Controller
    {
        CompanyEntities dc = new CompanyEntities();
        // GET: Default
        public ActionResult Index()
        {
            return View(dc.tblemployees.ToList());
        }

        public ActionResult EmpDetails(int id)
        {
            return View(dc.tblemployees.Find(id));
        }

        [HttpGet]
        public ActionResult AddEmp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmp(tblemployee obj)
        {
            dc.tblemployees.Add(obj);   // add to entity memory
            dc.SaveChanges();   //add to database
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            return View(dc.tblemployees.Find(id));
        }
        [HttpPost]
        public ActionResult Edit(tblemployee obj)
        {
            dc.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            dc.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            return View(dc.tblemployees.Find(id));
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteRec(int id)
        {
            dc.tblemployees.Remove(dc.tblemployees.Find(id));
            dc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}