using LoginC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace LoginC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            IEnumerable<Administrator> empobj = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44357/api/EmpCrud");
            var consumeapi = hc.GetAsync("EmpCrud");
            consumeapi.Wait();
            var readdata = consumeapi.Result;
            if (readdata.IsSuccessStatusCode)
            {
                var displaydata = readdata.Content.ReadAsAsync<IList<Administrator>>();
                displaydata.Wait();
                empobj = displaydata.Result;

            }
            return View(empobj);
           
        }
        public ActionResult Details(int id)
        {
            EmpClass empobj = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44357/api/");
            var Consumeapi = hc.GetAsync("EmpCrud?id=" + id.ToString());
            Consumeapi.Wait();
            var readdata = Consumeapi.Result;
            if (readdata.IsSuccessStatusCode)
            {
                var displaydata = readdata.Content.ReadAsAsync<EmpClass>();
                displaydata.Wait();
                empobj = displaydata.Result;

            }
            return View(empobj);



        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmpClass ec)
        {
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44357/api/EmpCrud");

            var insertdata = hc.PostAsJsonAsync<EmpClass>("EmpCrud",ec);
            insertdata.Wait();
            var savedata = insertdata.Result;
            if(savedata.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }


            return View("Create");

        }
        public ActionResult Edit(int id)
        {
            EmpClass empobj = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44357/api/");
            var Consumeapi = hc.GetAsync("EmpCrud?id=" + id.ToString());
            Consumeapi.Wait();
            var readdata = Consumeapi.Result;
            if (readdata.IsSuccessStatusCode)
            {
                var displaydata = readdata.Content.ReadAsAsync<EmpClass>();
                displaydata.Wait();
                empobj = displaydata.Result;

            }
            return View(empobj);

        }

    
    [HttpPost]
    public ActionResult Edit(EmpClass ec)
    {
        HttpClient hc = new HttpClient();
        hc.BaseAddress = new Uri("https://localhost:44357/api/EmpCrud");

        var insertdata = hc.PutAsJsonAsync<EmpClass>("EmpCrud", ec);
        insertdata.Wait();
        var savedata = insertdata.Result;
        if (savedata.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");

        }


        return View(ec);
    }
        public ActionResult Delete(int id)
        {
          
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44357/api/EmpCrud");
            var Consumeapi = hc.DeleteAsync("EmpCrud/" + id.ToString());
            Consumeapi.Wait();
            var deletedata = Consumeapi.Result;
            if (deletedata.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }
            return View("Index");
        }
    }
}