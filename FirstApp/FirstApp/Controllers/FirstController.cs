using FirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApp.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Sample()
        {
            return View();
        }

        public ActionResult Sample2()
        {
            return View();
        }

        public ActionResult Index()
        {
            List<Employee> li = new List<Employee>();
            li.Add(new Employee { empid=1,fname="Prakash",salary=45000,mobile="9878",email="pr@gmail.com" });
            li.Add(new Employee { empid=2,fname="Parth",salary=45000,mobile="9878",email="p@gmail.com" });
            li.Add(new Employee { empid=3,fname="jenees",salary=45000,mobile="9878",email="je@gmail.com" });
            li.Add(new Employee { empid=4,fname="Bhavik",salary=45000,mobile="9878",email="bh@gmail.com" });
            return View(li);
        }
    }
}