using RazorControls.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RazorControls.EDM;

namespace RazorControls.Controllers
{
    public class DefaultController : Controller
    {
        CompanyEntities dc = new CompanyEntities();
        // GET: Default
        public ActionResult Index()
        {
            return View(dc.tblemployees.ToList());
        }
        void FillCity()
        {
            List<SelectListItem> li = new List<SelectListItem>();

            var cities = dc.tblcities.ToList();

            foreach (var item in cities)
            {
                li.Add(new SelectListItem { Value = item.city_id.ToString(), Text = item.city_name });
            }

            //li.Add(new SelectListItem { Value="1", Text="Surat" });
            //li.Add(new SelectListItem { Value="2", Text="bharuch" });
            //li.Add(new SelectListItem { Value="3", Text="Gandhinagar" });
            //li.Add(new SelectListItem { Value="4", Text="Vapi" });

            ViewBag.city = li;
        }

        public ActionResult Create()
        {
            FillCity();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee obj, FormCollection fc, HttpPostedFileBase file)
        {
            bool Reading = Convert.ToBoolean(fc["Reading"].Split(',')[0]);
            bool Playing = Convert.ToBoolean(fc["Playing"].Split(',')[0]);
            bool Travelling = Convert.ToBoolean(fc["Travelling"].Split(',')[0]);
            string hob = "";
            if (Reading == true)
                hob += "Reading, ";
            if (Playing == true)
                hob += "Playing, ";
            if (Travelling == true)
                hob += "Travelling, ";

            obj.hobbies = hob;

            if (file != null)
            {
                string filename = Path.GetFileName(file.FileName);
                string fullpath = Path.Combine(Server.MapPath("~/Docs"), filename);
                file.SaveAs(fullpath);
                obj.profileimg = filename;
            }

            return View();
        }
    }
}