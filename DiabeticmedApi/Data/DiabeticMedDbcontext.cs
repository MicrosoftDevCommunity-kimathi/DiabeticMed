using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiabeticmedApi.Model;
using Microsoft.EntityFrameworkCore;

namespace DiabeticmedApi.Data
{
    public class DiabeticMedDbcontext:DbContext
    {
        public DiabeticMedDbcontext(DbContextOptions<DiabeticMedDbcontext> options):base(options)
        { }
        public DbSet<Patient> Patients { get; set; }
    }
}
