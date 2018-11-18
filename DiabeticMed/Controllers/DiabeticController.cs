using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DiabeticMed.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DiabeticMed.Controllers
{
    public class DiabeticController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<Patients> patients = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress=new Uri("http://localhost:54814/api/");
                var responseTask = client.GetAsync("Patients");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();
                    patients = Patients.FromJson(readTask.Result);
                }
                else
                {
                    patients = Enumerable.Empty<Patients>();
                    ModelState.AddModelError(string.Empty,"Server error .Please contact the admin");
                }

            }
            return View(patients);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Patients patient)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress=new Uri("http://localhost:54814/api/");
                //httppost
                var postTask = client.PostAsync("Patients",
                    new StringContent(JsonConvert.SerializeObject(patient), Encoding.UTF8, "application/json"));
                postTask.Wait();
                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            ModelState.AddModelError(string.Empty,"Server Error .please make sure web api is working");
            return View(patient);
        }
    }
}