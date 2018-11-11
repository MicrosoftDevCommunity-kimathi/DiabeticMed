﻿// <auto-generated />
using DiabeticProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DiabeticProject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DiabeticProject.Models.MedicPatientRepo.MedicPatient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<float>("BMi");

                    b.Property<float>("Diabetic");

                    b.Property<float>("DiabeticPadiac");

                    b.Property<float>("DiasotolicBloodPressure");

                    b.Property<bool>("Isdiabetic");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<float>("PlasmaGlucose");

                    b.Property<int>("Pregnanicies");

                    b.Property<float>("Seruminium");

                    b.Property<float>("TricepThickness");

                    b.HasKey("Id");

                    b.ToTable("MedicPatients");
                });
#pragma warning restore 612, 618
        }
    }
}
