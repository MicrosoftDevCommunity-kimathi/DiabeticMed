﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DiabeticProject.Data;
using Microsoft.AspNetCore.Mvc;
using DiabeticProject.Models;
using DiabeticProject.Models.MedicPatientRepo;
using DiabeticProject.Services;
using SQLitePCL;

namespace DiabeticProject.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
         [HttpPost]
        public IActionResult Result([FromBody] MedicPatient medicPatient)
        {
            if (!ModelState.IsValid)
            {
                RedirectToAction("Index");
            }

            _context.MedicPatients.Add(medicPatient);
            _context.SaveChanges();
            var result = _context.MedicPatients.Find(medicPatient);

            return View(result);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
      

    }
}