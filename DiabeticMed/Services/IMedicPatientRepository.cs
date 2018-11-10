using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiabeticMed.Models;

namespace DiabeticMed.Services
{
   public interface IMedicPatientRepository
   {
       IQueryable<MedicPatient> Product { get; }
       IEnumerable<MedicPatient> GetDiabetics();
       IEnumerable<MedicPatient> GetnonDiabetics();
       MedicPatient GetMedicPatient(int id);


   }
}
