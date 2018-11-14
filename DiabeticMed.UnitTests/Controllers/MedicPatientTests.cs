using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using DiabeticProject.Controllers;
using DiabeticProject.Models;
using DiabeticProject.Models.MedicPatientRepo;
using DiabeticProject.Services;
using Moq;
using Xunit;
using FakeMedicPatientsRepository = DiabeticMed.UnitTests.MockData.FakeMedicPatientsRepository;

namespace DiabeticMed.UnitTests.Controllers
{
   public class MedicPatientTests
    {
        [Fact]
        public void Can_paginate()
        {
            //arrange 
            Mock<IMedicPatientRepository> mock=new Mock<IMedicPatientRepository>();
            mock.Setup(p => p.AllMedicPatients).Returns(new FakeMedicPatientsRepository().AllMedicPatients);

            MedicPatientController controller=new MedicPatientController(mock.Object);
            controller.Pagesize = 3;
            //Act
            //assert
            PatientsMEdListviewModel result=controller.Index(null,6).ViewData.Model as PatientsMEdListviewModel;
            MedicPatient[] patientarr = result.Patients.ToArray();
            Assert.True(patientarr.Length==1);

        }

        [Fact]
        public void Can_Send_Paginations_view_model()
        {
            Mock<IMedicPatientRepository> mock=new Mock<IMedicPatientRepository>();
            mock.Setup(p => p.AllMedicPatients).Returns(new FakeMedicPatientsRepository().AllMedicPatients);

            //arrange
            MedicPatientController controller=new MedicPatientController(mock.Object)
            {
                Pagesize = 3
            };

            //Act
            PatientsMEdListviewModel result=controller.Index(null,6).ViewData.Model as PatientsMEdListviewModel;
            //asset
            PagingInfo pageinfo = result.PagingInfo;

            Assert.Equal(6,pageinfo.CurrentPage);
            Assert.Equal(3, pageinfo.ItemsPerPage);
            Assert.Equal(16, pageinfo.TotalItems);
            Assert.Equal(6,pageinfo.TotalPages);
        }
    }
}
