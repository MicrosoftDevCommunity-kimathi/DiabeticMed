using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using DiabeticMed.Controllers;
using DiabeticMed.Models;
using DiabeticMed.Services;
using DiabeticMed.UnitTests.MockData;
using Moq;
using Xunit;

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
            IEnumerable<MedicPatient> result = controller.Index(2).ViewData.Model as IEnumerable<MedicPatient>;
            //assert
            MedicPatient[] patientarr = result.ToArray();
            Assert.True(patientarr.Length==3);

        }
    }
}
