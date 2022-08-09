using CreateApi.EDM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CreateApi.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public async Task<ActionResult> Index()
        {
            IEnumerable<tblemployee> li = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44390/");

                var response = await client.GetAsync("Api/Default");
                if (response.IsSuccessStatusCode)
                {
                    li = await response.Content.ReadAsAsync<IList<tblemployee>>();
                }
            }

            return View(li);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(tblemployee obj)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44390/");

                var response = await client.PostAsJsonAsync<tblemployee>("Api/Default", obj);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            ModelState.AddModelError(string.Empty, "Error.!");
            return View();
        }

        public async Task<ActionResult> Edit(int id)
        {
            tblemployee obj = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44390/");

                var response = await client.GetAsync("Api/Default/" + id);
                if (response.IsSuccessStatusCode)
                {
                    obj = await response.Content.ReadAsAsync<tblemployee>();
                }
            }

            return View(obj);
        }
        [HttpPost]
        public async Task<ActionResult> Edit(tblemployee obj)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44390/");

                var response = await client.PutAsJsonAsync<tblemployee>("Api/Default/" + obj.emp_id, obj);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            ModelState.AddModelError(string.Empty, "Error.!");
            return View();
        }
        public async Task<ActionResult> Delete(int id)
        {
            tblemployee obj = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44390/");

                var response = await client.GetAsync("Api/Default/" + id);
                if (response.IsSuccessStatusCode)
                {
                    obj = await response.Content.ReadAsAsync<tblemployee>();
                }
            }

            return View(obj);
        }
        [HttpPost]
        [ActionName("Delete")]
        public async Task<ActionResult> DeleteRec(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44390/");

                var response = await client.DeleteAsync("Api/Default/" + id);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            ModelState.AddModelError(string.Empty, "Error.!");
            return View();
        }
    }
}