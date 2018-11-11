using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiabeticMed.Models.MedicPatientRepo
{
    public class PatientsMEdListviewModel
    {
        public IEnumerable<MedicPatient> Patients  { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
