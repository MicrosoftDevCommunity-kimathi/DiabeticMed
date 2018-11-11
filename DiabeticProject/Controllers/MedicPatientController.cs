using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiabeticProject.Models;
using DiabeticProject.Models.MedicPatientRepo;
using DiabeticProject.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DiabeticProject.Controllers
{
    public class MedicPatientController : Controller
    {
        private IMedicPatientRepository _repository;
        public int Pagesize = 4;

        public MedicPatientController(IMedicPatientRepository repository)
        {
            _repository = repository;
        }

        // GET: /<controller>/
        public ViewResult Index(int productPage = 1)
        {
            var model = new PatientsMEdListviewModel()
            {
                Patients = _repository.AllMedicPatients.OrderBy(p => p.Name).Skip((productPage - 1) * Pagesize)
                    .Take(Pagesize),
                PagingInfo = new PagingInfo()
                {
                    CurrentPage = productPage,
                    ItemsPerPage = Pagesize,
                    TotalItems = _repository.AllMedicPatients.Count()
                }
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