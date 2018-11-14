using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiabeticProject.Models;
using DiabeticProject.Models.MedicPatientRepo;

namespace DiabeticProject.Models.MedicPatientRepo
{
    public class PatientsMEdListviewModel
    {
        public IEnumerable<MedicPatient> Patients  { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
