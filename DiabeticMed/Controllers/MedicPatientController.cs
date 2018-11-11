using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiabeticMed.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DiabeticMed.Controllers
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
        public ViewResult Index(int productPage=1)
        {
            return View(_repository.AllMedicPatients
                .OrderBy(p=>p.Name).Skip((productPage-1)*Pagesize)
                .Take(Pagesize));
        }
    }
}
