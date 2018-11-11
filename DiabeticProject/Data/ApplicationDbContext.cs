using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiabeticProject.Models;
using DiabeticProject.Models.MedicPatientRepo;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DiabeticProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<MedicPatient> MedicPatients { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
      
        }
    }
}
