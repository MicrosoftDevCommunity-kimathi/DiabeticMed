using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiabeticProject.Models;
using DiabeticProject.Models.MedicPatientRepo;
using DiabeticProject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DiabeticProject.Controllers
{
    [Authorize]
    public class MedicPatientController : Controller
    {
        private IMedicPatientRepository _repository;
        public int Pagesize = int.MaxValue;

        public MedicPatientController(IMedicPatientRepository repository)
        {
            _repository = repository;
        }

        // GET: /<controller>/
        public ViewResult Index(string category,int productPage = 1)
        {
            var model = new PatientsMEdListviewModel()
            {
                Patients = _repository.AllMedicPatients.OrderBy(p => p.Id).Skip((productPage - 1) * Pagesize)
                    .Take(Pagesize),
                PagingInfo = new PagingInfo()
                {
                    CurrentPage = productPage,
                    ItemsPerPage = Pagesize,
                    TotalItems = _repository.AllMedicPatients.Count()
                }   ,
              CurrentCategory = category
            };
            return View(model);
        }

        public ViewResult Diabetic()
        {
            return View(_repository.GetDiabetics());
        }

        public ViewResult NonDiabetic()
        {
            return View(_repository.GetnonDiabetics());
        }



    }
}