using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DiabeticMed.Services;
using Microsoft.AspNetCore.Mvc;

namespace DiabeticMed.Models
{
    public class PatientDbClient :IMedicPatientRepository
    {
        private static readonly HttpClient client =new HttpClient();
        public async Task<List<Patients>> GetPatients()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            var stringTask = client.GetStringAsync("http://localhost:54814/api/Patients");
            var msg = await stringTask;
             var patients = Patients.FromJson(msg);
            return patients;
        }

        public Task<IActionResult> GetPatient(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> PutPatient(int id, Patients patient)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> PostPatient(Patients patient)
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
