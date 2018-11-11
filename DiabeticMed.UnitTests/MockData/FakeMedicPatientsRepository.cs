using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiabeticMed.Models;
using DiabeticMed.Services;

namespace DiabeticMed.UnitTests.MockData
{
    public class FakeMedicPatientsRepository: IMedicPatientRepository
    {
        public IQueryable<MedicPatient> AllMedicPatients =>new List<MedicPatient>
        {
           new MedicPatient{Id = 1,Name = "Edwin",Age = 21,Pregnanicies = 2,BMi = 34,Diabetic = 1.343F,DiabeticPadiac = 46,DiasotolicBloodPressure = 35,Image = @"http://google.com",Isdiabetic = false},
           new MedicPatient{Id = 2,Name = "Jane",Age = 13,Pregnanicies = 0,BMi = 34,Diabetic = 45,DiabeticPadiac = 46,DiasotolicBloodPressure = 35,Image = @"http://google.com",Isdiabetic = true},
           new MedicPatient{Id = 3,Name = "Kimani",Age = 21,Pregnanicies = 1,BMi = 34,Diabetic = 0.65F,DiabeticPadiac = 46,DiasotolicBloodPressure = 35,Image = @"http://google.com",Isdiabetic = false},
           new MedicPatient{Id = 4,Name = "Joy",Age = 34,Pregnanicies = 2,BMi = 34,Diabetic = 1.3456F,DiabeticPadiac = 46,DiasotolicBloodPressure = 35,Image = @"http://google.com",Isdiabetic = false},
           new MedicPatient{Id = 5,Name = "Wanjiru",Age = 28,Pregnanicies = 2,BMi = 34,Diabetic = 1.676F,DiabeticPadiac = 46,DiasotolicBloodPressure = 35,Image = @"http://google.com",Isdiabetic = false},
           new MedicPatient{Id = 6,Name = "Nancy",Age = 31,Pregnanicies = 1,BMi = 34,Diabetic = 1.4545F,DiabeticPadiac = 46,DiasotolicBloodPressure = 35,Image = @"http://google.com",Isdiabetic = false},
           new MedicPatient{Id = 7,Name = "Jane",Age = 34,Pregnanicies = 4,BMi = 34,Diabetic = 1.5643F,DiabeticPadiac = 46,DiasotolicBloodPressure = 35,Image = @"http://google.com",Isdiabetic = false},
           new MedicPatient{Id = 8,Name = "Anne",Age = 78,Pregnanicies = 5,BMi = 34,Diabetic = 1.454F,DiabeticPadiac = 46,DiasotolicBloodPressure = 35,Image = @"http://google.com",Isdiabetic = false},
           new MedicPatient{Id = 9,Name = "Faith",Age = 34,Pregnanicies = 2,BMi = 34,Diabetic = 1.442F,DiabeticPadiac = 46,DiasotolicBloodPressure = 35,Image = @"http://google.com",Isdiabetic = false},
           new MedicPatient{Id = 10,Name = "Jasmine",Age = 12,Pregnanicies = 0,BMi = 34,Diabetic = 1.2424F,DiabeticPadiac = 46,DiasotolicBloodPressure = 35,Image = @"http://google.com",Isdiabetic = false},
           new MedicPatient{Id = 11,Name = "Mary",Age = 45,Pregnanicies = 4,BMi = 34,Diabetic = 0,DiabeticPadiac = 46,DiasotolicBloodPressure = 35,Image = @"http://google.com",Isdiabetic = false},
           new MedicPatient{Id = 12,Name = "Ivvonye",Age = 12,Pregnanicies = 0,BMi = 34,Diabetic = 0,DiabeticPadiac = 46,DiasotolicBloodPressure = 35,Image = @"http://google.com",Isdiabetic = false},
           new MedicPatient{Id = 13,Name = "Lovvy",Age = 43,Pregnanicies = 2,BMi = 34,Diabetic = 0,DiabeticPadiac = 46,DiasotolicBloodPressure = 35,Image = @"http://google.com",Isdiabetic = false},
           new MedicPatient{Id = 14,Name = "Anastasia",Age = 65,Pregnanicies = 3,BMi = 34,Diabetic = 78,DiabeticPadiac = 46,DiasotolicBloodPressure = 35,Image = @"http://google.com",Isdiabetic = true},
           new MedicPatient{Id = 15,Name = "Miracle",Age = 19,Pregnanicies = 1,BMi = 34,Diabetic = 34,DiabeticPadiac = 46,DiasotolicBloodPressure = 35,Image = @"http://google.com",Isdiabetic = true},
           new MedicPatient{Id = 16,Name = "Patience",Age = 13,Pregnanicies = 0,BMi = 34,Diabetic = 34,DiabeticPadiac = 46,DiasotolicBloodPressure = 35,Image = @"http://google.com",Isdiabetic = true},

        }.AsQueryable<MedicPatient>();

        public IEnumerable<MedicPatient> GetDiabetics()
        {
            return AllMedicPatients.Where(p => p.Isdiabetic == true);
        }

        public IEnumerable<MedicPatient> GetnonDiabetics()
        {
            return AllMedicPatients.Where(p => p.Isdiabetic == false);
        }

        public MedicPatient GetMedicPatient(int id)
        {
            return AllMedicPatients.SingleOrDefault(p => p.Id == id);
        }
    }
}
