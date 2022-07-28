using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModalPopup.EDM;

namespace ModalPopup.Controllers
{
    public class DefaultController : Controller
    {
        CompanyEntities dc = new CompanyEntities();
        // GET: Default
        public ActionResult Index()
        {
            return View(dc.tblemployees.ToList());
        }

        public ActionResult Create(int? id)
        {
            if (id == null)   //create
            {
                return View();
            }
            else
            {
                return View(dc.tblemployees.Find(id));
            }
        }
        [HttpPost]
        public ActionResult Create(tblemployee obj)
        {
            if (obj.emp_id == 0)
            {
                dc.tblemployees.Add(obj);
                dc.SaveChanges();
            }
            else
            {
                dc.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                dc.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public string Delete(int id)
        {
            dc.tblemployees.Remove(dc.tblemployees.Find(id));
            dc.SaveChanges();
            return "Delete Success";
        }

    }
}