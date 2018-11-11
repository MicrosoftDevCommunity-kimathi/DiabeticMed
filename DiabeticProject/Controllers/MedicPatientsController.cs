using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DiabeticProject.Data;
using DiabeticProject.Models.MedicPatientRepo;

namespace DiabeticProject.Controllers
{
    [Produces("application/json")]
    [Route("api/MedicPatients")]
    public class MedicPatientsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MedicPatientsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MedicPatients
        [HttpGet]
        public IEnumerable<MedicPatient> GetMedicPatients()
        {
            return _context.MedicPatients;
        }

        // GET: api/MedicPatients/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMedicPatient([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var medicPatient = await _context.MedicPatients.SingleOrDefaultAsync(m => m.Id == id);

            if (medicPatient == null)
            {
                return NotFound();
            }

            return Ok(medicPatient);
        }

        // PUT: api/MedicPatients/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMedicPatient([FromRoute] int id, [FromBody] MedicPatient medicPatient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != medicPatient.Id)
            {
                return BadRequest();
            }

            _context.Entry(medicPatient).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedicPatientExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/MedicPatients
        [HttpPost]
        public async Task<IActionResult> PostMedicPatient([FromBody] MedicPatient medicPatient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MedicPatients.Add(medicPatient);
            await _context.SaveChangesAsync();

            return CreatedAtAction(@"GetMedicPatient", new { id = medicPatient.Id }, medicPatient);
        }

        // DELETE: api/MedicPatients/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMedicPatient([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var medicPatient = await _context.MedicPatients.SingleOrDefaultAsync(m => m.Id == id);
            if (medicPatient == null)
            {
                return NotFound();
            }

            _context.MedicPatients.Remove(medicPatient);
            await _context.SaveChangesAsync();

            return Ok(medicPatient);
        }

        private bool MedicPatientExists(int id)
        {
            return _context.MedicPatients.Any(e => e.Id == id);
        }
    }
}