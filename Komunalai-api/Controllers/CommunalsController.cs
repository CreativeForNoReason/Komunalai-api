using Microsoft.AspNetCore.Mvc;
using Komunalaiapi.Models;
using Komunalaiapi.Repositories;

namespace Komunalaiapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommunalsController : ControllerBase
    {
        private readonly ICommunalRepository _repository;

        public CommunalsController(ICommunalRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Communals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Communal>>> GetCommunals()
        {
            var communals = await _repository.GetCommunals();
            if (communals == null)
            {
                return NotFound();
            }
            return communals;
        }

        // GET: api/Communals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Communal>> GetCommunal(int id)
        {
            var communal = await _repository.GetCommunal(id);
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

            await _repository.UpdateCommunal(id, communal);

            return NoContent();
        }

        // POST: api/Communals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Communal>> PostCommunal(Communal communal)
        {
            await _repository.AddCommunal(communal);

            return CreatedAtAction("GetCommunal", new { id = communal.Id }, communal);
        }

        // DELETE: api/Communals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCommunal(int id)
        {
            await _repository.DeleteCommunal(id);
            
            return NoContent();
        }
    }
}
