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
        private readonly string connectionstring="http://localhost:54815/api/Patients";
        public IActionResult Index()
        {
            IEnumerable<Patients> patients = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress=new Uri(connectionstring);
                var responseTask = client.GetAsync("");
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
                client.BaseAddress=new Uri(connectionstring);
                //httppost
                var postTask = client.PostAsync("",
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

        public IActionResult Edit(long id)
        {
            Patients patient = null;
            using (var client = new HttpClient())
            {
                //http get
                var response = client.GetAsync("Patients?id=" + id.ToString());
                response.Wait();
                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();
                    patient = JsonConvert.DeserializeObject<Patients>(readTask.Result);

                }

            }

            return View(patient);
        }

        [HttpPost]
        public ActionResult Edit(Patients patient)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress=new Uri(connectionstring);
                //Http post
                var putTask = client.PutAsync("Patients",
                    new StringContent(JsonConvert.SerializeObject(patient), Encoding.UTF8, "application/json"));
                putTask.Wait();
                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            return View(patient);
        }

        public IActionResult Delete(long id)
        {
            using (var client = new HttpClient())
            {
                //Http delete
                var deleteTask = client.DeleteAsync($"{connectionstring}/Patients/{id}");
                deleteTask.Wait();
                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Index");
        }
    }
    }
