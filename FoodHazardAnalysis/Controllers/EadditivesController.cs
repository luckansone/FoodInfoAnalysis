using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FoodHazardAnalysis.Models;
using FoodHazardAnalysis.Interfaces.Repositories;

namespace FoodHazardAnalysis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EadditivesController : ControllerBase
    {
        private readonly IService<Eadditives> _service;
        private readonly FoodHazardBotDBContext _context;

        public EadditivesController(FoodHazardBotDBContext context, IService<Eadditives> service)
        {
            _context = context;
            _service = service;
        }

        public Services.EAdditiveService EAdditiveService
        {
            get => default(Services.EAdditiveService);
            set
            {
            }
        }

        // GET: api/Eadditives
        [HttpGet]
        public IEnumerable<Eadditives> GetEadditives()
        {
            return _service.GetAll();
        }

        // GET: api/Eadditives/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEadditives([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var eadditives =  _service.GetById(id);

            if (eadditives == null)
            {
                return NotFound();
            }

            return Ok(eadditives);
        }

        // PUT: api/Eadditives/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEadditives([FromRoute] int id, [FromBody] Eadditives eadditives)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eadditives.Id)
            {
                return BadRequest();
            }

            _context.Entry(eadditives).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EadditivesExists(id))
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

        // POST: api/Eadditives
        [HttpPost]
        public async Task<IActionResult> PostEadditives([FromBody] Eadditives eadditives)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Additives.Add(eadditives);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEadditives", new { id = eadditives.Id }, eadditives);
        }

        // DELETE: api/Eadditives/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEadditives([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var eadditives = await _context.Additives.FindAsync(id);
            if (eadditives == null)
            {
                return NotFound();
            }

            _context.Additives.Remove(eadditives);
            await _context.SaveChangesAsync();

            return Ok(eadditives);
        }

        private bool EadditivesExists(int id)
        {
            return _context.Additives.Any(e => e.Id == id);
        }
    }
}