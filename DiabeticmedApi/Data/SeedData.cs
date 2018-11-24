using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiabeticmedApi.Data;
using DiabeticmedApi.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DiabeticmedApi.Data
{
    public static class SeedData
    {
        public static void EnsurePatientPopulated(IApplicationBuilder app)
        {
            DiabeticMedDbcontext context = app.ApplicationServices
                .GetRequiredService<DiabeticMedDbcontext>();
            context.Database.Migrate();
            if (!context.Patients.Any())
            {
                context.AddRange(
               
                    new Patient {  Name = "Edwin", Age = 21, Pregnanicies = 2, BMi = 34, Diabetic = 1.343F, DiabeticPadiac = 46, DiasotolicBloodPressure = 35,  Isdiabetic = false },
           new Patient { Name = "Jane", Age = 13, Pregnanicies = 0, BMi = 34, Diabetic = 45, DiabeticPadiac = 46, DiasotolicBloodPressure = 35,  Isdiabetic = true },
           new Patient {  Name = "Kimani", Age = 21, Pregnanicies = 1, BMi = 34, Diabetic = 0.65F, DiabeticPadiac = 46, DiasotolicBloodPressure = 35,  Isdiabetic = false },
           new Patient {  Name = "Joy", Age = 34, Pregnanicies = 2, BMi = 34, Diabetic = 1.3456F, DiabeticPadiac = 46, DiasotolicBloodPressure = 35,  Isdiabetic = false },
           new Patient {  Name = "Wanjiru", Age = 28, Pregnanicies = 2, BMi = 34, Diabetic = 1.676F, DiabeticPadiac = 46, DiasotolicBloodPressure = 35,  Isdiabetic = false },
           new Patient {  Name = "Nancy", Age = 31, Pregnanicies = 1, BMi = 34, Diabetic = 1.4545F, DiabeticPadiac = 46, DiasotolicBloodPressure = 35,  Isdiabetic = false },
           new Patient {  Name = "Jane", Age = 34, Pregnanicies = 4, BMi = 34, Diabetic = 1.5643F, DiabeticPadiac = 46, DiasotolicBloodPressure = 35,  Isdiabetic = false },
           new Patient {  Name = "Anne", Age = 78, Pregnanicies = 5, BMi = 34, Diabetic = 1.454F, DiabeticPadiac = 46, DiasotolicBloodPressure = 35,  Isdiabetic = false },
           new Patient {  Name = "Faith", Age = 34, Pregnanicies = 2, BMi = 34, Diabetic = 1.442F, DiabeticPadiac = 46, DiasotolicBloodPressure = 35,  Isdiabetic = false },
           new Patient {  Name = "Jasmine", Age = 12, Pregnanicies = 0, BMi = 34, Diabetic = 1.2424F, DiabeticPadiac = 46, DiasotolicBloodPressure = 35,  Isdiabetic = false },
           new Patient {  Name = "Mary", Age = 45, Pregnanicies = 4, BMi = 34, Diabetic = 0, DiabeticPadiac = 46, DiasotolicBloodPressure = 35,  Isdiabetic = false },
           new Patient {  Name = "Ivvonye", Age = 12, Pregnanicies = 0, BMi = 34, Diabetic = 0, DiabeticPadiac = 46, DiasotolicBloodPressure = 35,  Isdiabetic = false },
           new Patient {  Name = "Lovvy", Age = 43, Pregnanicies = 2, BMi = 34, Diabetic = 0, DiabeticPadiac = 46, DiasotolicBloodPressure = 35,  Isdiabetic = false },
           new Patient {  Name = "Anastasia", Age = 65, Pregnanicies = 3, BMi = 34, Diabetic = 78, DiabeticPadiac = 46, DiasotolicBloodPressure = 35,  Isdiabetic = true },
           new Patient {  Name = "Miracle", Age = 19, Pregnanicies = 1, BMi = 34, Diabetic = 34, DiabeticPadiac = 46, DiasotolicBloodPressure = 35,  Isdiabetic = true },
           new Patient { Name = "Patience", Age = 13, Pregnanicies = 0, BMi = 34, Diabetic = 34, DiabeticPadiac = 46, DiasotolicBloodPressure = 35,  Isdiabetic = true }
                );
                context.SaveChanges();
            }
        }
    }
}
