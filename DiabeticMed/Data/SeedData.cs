using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiabeticMed.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DiabeticMed.Data
{
    public static class SeedData
    {
        public static void EnsurePatientPopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.MedicPatients.Any())
            {
                context.AddRange(
               
                    new MedicPatient {  Name = "Edwin", Age = 21, Pregnanicies = 2, BMi = 34, Diabetic = 1.343F, DiabeticPadiac = 46, DiasotolicBloodPressure = 35, Image = @"http://google.com", Isdiabetic = false },
           new MedicPatient { Name = "Jane", Age = 13, Pregnanicies = 0, BMi = 34, Diabetic = 45, DiabeticPadiac = 46, DiasotolicBloodPressure = 35, Image = @"http://google.com", Isdiabetic = true },
           new MedicPatient {  Name = "Kimani", Age = 21, Pregnanicies = 1, BMi = 34, Diabetic = 0.65F, DiabeticPadiac = 46, DiasotolicBloodPressure = 35, Image = @"http://google.com", Isdiabetic = false },
           new MedicPatient {  Name = "Joy", Age = 34, Pregnanicies = 2, BMi = 34, Diabetic = 1.3456F, DiabeticPadiac = 46, DiasotolicBloodPressure = 35, Image = @"http://google.com", Isdiabetic = false },
           new MedicPatient {  Name = "Wanjiru", Age = 28, Pregnanicies = 2, BMi = 34, Diabetic = 1.676F, DiabeticPadiac = 46, DiasotolicBloodPressure = 35, Image = @"http://google.com", Isdiabetic = false },
           new MedicPatient {  Name = "Nancy", Age = 31, Pregnanicies = 1, BMi = 34, Diabetic = 1.4545F, DiabeticPadiac = 46, DiasotolicBloodPressure = 35, Image = @"http://google.com", Isdiabetic = false },
           new MedicPatient {  Name = "Jane", Age = 34, Pregnanicies = 4, BMi = 34, Diabetic = 1.5643F, DiabeticPadiac = 46, DiasotolicBloodPressure = 35, Image = @"http://google.com", Isdiabetic = false },
           new MedicPatient {  Name = "Anne", Age = 78, Pregnanicies = 5, BMi = 34, Diabetic = 1.454F, DiabeticPadiac = 46, DiasotolicBloodPressure = 35, Image = @"http://google.com", Isdiabetic = false },
           new MedicPatient {  Name = "Faith", Age = 34, Pregnanicies = 2, BMi = 34, Diabetic = 1.442F, DiabeticPadiac = 46, DiasotolicBloodPressure = 35, Image = @"http://google.com", Isdiabetic = false },
           new MedicPatient {  Name = "Jasmine", Age = 12, Pregnanicies = 0, BMi = 34, Diabetic = 1.2424F, DiabeticPadiac = 46, DiasotolicBloodPressure = 35, Image = @"http://google.com", Isdiabetic = false },
           new MedicPatient {  Name = "Mary", Age = 45, Pregnanicies = 4, BMi = 34, Diabetic = 0, DiabeticPadiac = 46, DiasotolicBloodPressure = 35, Image = @"http://google.com", Isdiabetic = false },
           new MedicPatient {  Name = "Ivvonye", Age = 12, Pregnanicies = 0, BMi = 34, Diabetic = 0, DiabeticPadiac = 46, DiasotolicBloodPressure = 35, Image = @"http://google.com", Isdiabetic = false },
           new MedicPatient {  Name = "Lovvy", Age = 43, Pregnanicies = 2, BMi = 34, Diabetic = 0, DiabeticPadiac = 46, DiasotolicBloodPressure = 35, Image = @"http://google.com", Isdiabetic = false },
           new MedicPatient {  Name = "Anastasia", Age = 65, Pregnanicies = 3, BMi = 34, Diabetic = 78, DiabeticPadiac = 46, DiasotolicBloodPressure = 35, Image = @"http://google.com", Isdiabetic = true },
           new MedicPatient {  Name = "Miracle", Age = 19, Pregnanicies = 1, BMi = 34, Diabetic = 34, DiabeticPadiac = 46, DiasotolicBloodPressure = 35, Image = @"http://google.com", Isdiabetic = true },
           new MedicPatient { Name = "Patience", Age = 13, Pregnanicies = 0, BMi = 34, Diabetic = 34, DiabeticPadiac = 46, DiasotolicBloodPressure = 35, Image = @"http://google.com", Isdiabetic = true }
                );
                context.SaveChanges();
            }
        }
    }
}
