using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DiabeticProject.Model;
using DiabeticProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace DiabeticProject.data
{
    public class PatientDbClient:IMedicPatientRepository
    {
       private static readonly HttpClient client=new HttpClient();

        public IEnumerable<Patient> GetPatients()
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetPatient(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> PutPatient(int id, Patient patient)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> PostPatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> DeletePatient(int id)
        {
            throw new NotImplementedException();
        }

        public bool PatientExists(int id)
        {
            throw new NotImplementedException();
        }
    }
}
