using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiabeticProject.Models.MedicPatientRepo;

namespace DiabeticProject.Services
{
   public interface IMedicPatientRepository
   {                              
       IQueryable<MedicPatient> AllMedicPatients { get; }
       IEnumerable<MedicPatient> GetDiabetics();
       IEnumerable<MedicPatient> GetnonDiabetics();
       MedicPatient GetMedicPatient(int id);


   }
}
