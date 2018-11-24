using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiabeticMed.Models;
using Microsoft.AspNetCore.Mvc;
 


namespace DiabeticMed.Services
{
   public interface IMedicPatientRepository
   {
       Task<List<Patients>> GetPatients();
       Task<IActionResult> GetPatient( int id);
       Task<IActionResult> PutPatient(int id, Patients patient);
       Task<IActionResult> PostPatient(Patients patient);
       Task<IActionResult> DeletePatient(int id);
       bool PatientExists(int id);
   }
}

