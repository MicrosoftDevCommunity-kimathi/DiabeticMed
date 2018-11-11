using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiabeticMed.Data;
using DiabeticProject.Data;
using DiabeticProject.Services;

namespace DiabeticProject.Models.MedicPatientRepo
{
    public class EfMedicalPatientRepository :IMedicPatientRepository
    {
        private ApplicationDbContext _context;

        public EfMedicalPatientRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<MedicPatient> AllMedicPatients => _context.MedicPatients;
        public IEnumerable<MedicPatient> GetDiabetics()
        {
            return _context.MedicPatients.Where(p => p.Isdiabetic.Equals(true));
        }

        public IEnumerable<MedicPatient> GetnonDiabetics()
        {
            return _context.MedicPatients.Where(p => p.Isdiabetic.Equals(false));

        }

        public MedicPatient GetMedicPatient(int id)
        {
            return _context.MedicPatients.SingleOrDefault(p => p.Id == id);
        }
    }
}
