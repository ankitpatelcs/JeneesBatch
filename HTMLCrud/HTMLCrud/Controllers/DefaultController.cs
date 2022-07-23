using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTMLCrud.EDM;

namespace HTMLCrud.Controllers
{
    public class DefaultController : Controller
    {
        CompanyEntities dc = new CompanyEntities();
        // GET: Default
        public ActionResult Index()
        {
            var data = from n in dc.tblemployees
                       select n;
            ViewBag.empdata = data.ToList();
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection fc)
        {
            tblemployee obj = new tblemployee();
            obj.f_name = fc["txtfn"];
            obj.salary = Convert.ToInt32(fc["txtsal"]);
            obj.email = fc["txtem"];
            obj.password = fc["txtpass"];
            obj.mobile = fc["txtmob"];
            obj.gender = fc["txtgen"];

            dc.tblemployees.Add(obj);
            dc.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var data = (from n in dc.tblemployees
                       where n.emp_id == id
                       select n).FirstOrDefault();
            ViewBag.empobj = data;
            return View();
        }

        [HttpPost]
        public ActionResult Edit(FormCollection fc)
        {
            tblemployee obj = new tblemployee();
            obj.f_name = fc["txtfn"];
            obj.salary = Convert.ToInt32(fc["txtsal"]);
            obj.emp_id = Convert.ToInt32(fc["txtid"]);
            obj.email = fc["txtem"];
            obj.password = fc["txtpass"];
            obj.mobile = fc["txtmob"];
            obj.gender = fc["txtgen"];

            dc.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            dc.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var data = (from n in dc.tblemployees
                        where n.emp_id == id
                        select n).FirstOrDefault();
            ViewBag.empobj = data;
            return View();
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