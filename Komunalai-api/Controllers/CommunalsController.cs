using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Komunalai_api.Data;
using Komunalai_api.Models;

namespace Komunalai_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommunalsController : ControllerBase
    {
        private readonly DataContext _context;

        public CommunalsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Communals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Communal>>> GetCommunals()
        {
          if (_context.Communals == null)
          {
              return NotFound();
          }
            return await _context.Communals.ToListAsync();
        }

        // GET: api/Communals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Communal>> GetCommunal(int id)
        {
          if (_context.Communals == null)
          {
              return NotFound();
          }
            var communal = await _context.Communals.FindAsync(id);

            if (communal == null)
            {
                return NotFound();
            }

            return communal;
        }

        // PUT: api/Communals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCommunal(int id, Communal communal)
        {
            if (id != communal.Id)
            {
                return BadRequest();
            }

            _context.Entry(communal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommunalExists(id))
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

        // POST: api/Communals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Communal>> PostCommunal(Communal communal)
        {
          if (_context.Communals == null)
          {
              return Problem("Entity set 'DataContext.Communals'  is null.");
          }
            _context.Communals.Add(communal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCommunal", new { id = communal.Id }, communal);
        }

        // DELETE: api/Communals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCommunal(int id)
        {
            if (_context.Communals == null)
            {
                return NotFound();
            }
            var communal = await _context.Communals.FindAsync(id);
            if (communal == null)
            {
                return NotFound();
            }

            _context.Communals.Remove(communal);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CommunalExists(int id)
        {
            return (_context.Communals?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
