using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxCrud.EDM;

namespace AjaxCrud.Controllers
{
    public class DefaultController : Controller
    {
        CompanyEntities dc = new CompanyEntities();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetEmployees()
        {
            dc.Configuration.ProxyCreationEnabled = false;
            return Json(dc.tblemployees.ToList(), JsonRequestBehavior.AllowGet);
        }

        void FillStates()
        {
            var stateslist = from s in dc.tblstates
                             select new SelectListItem
                             {
                                 Value=s.state_id.ToString(),
                                 Text=s.state_name
                             };
            ViewBag.states = stateslist.ToList();
        }

        public JsonResult GetCitiesByStateId(int id)
        {
            dc.Configuration.ProxyCreationEnabled = false;
            var cities= dc.tblcities.Where(c => c.state_id == id).ToList();
            return Json(cities,JsonRequestBehavior.AllowGet);
        }

        public ActionResult Create()
        {
            FillStates();
            return View();
        }
        [HttpPost]
        public string Create(tblemployee obj)
        {
            dc.tblemployees.Add(obj);
            dc.SaveChanges();
            return "Record Inserted.";
        }
        public ActionResult Edit(int id)
        {
            return View(dc.tblemployees.Find(id));
        }
        [HttpPost]
        public string Edit(tblemployee obj)
        {
            dc.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            dc.SaveChanges();
            return "Record Updated.";
        }
        public ActionResult Delete(int id)
        {
            return View(dc.tblemployees.Find(id));
        }
        [HttpPost]
        [ActionName("Delete")]
        public string DeleteRec(int id)
        {
            dc.tblemployees.Remove(dc.tblemployees.Find(id));
            dc.SaveChanges();
            return "Record Deleted.";
        }
    }
}