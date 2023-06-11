using Komunalai_api.Models;
using Microsoft.EntityFrameworkCore;

namespace Komunalai_api.Data
{
    public class LayeredDbcontext : ILayeredDbContext
    {
        private readonly ApplicationDbContext _context;

        public LayeredDbcontext(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddCommunal(Communal communal)
        {
            _context.Add(communal);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCommunal(int id)
        {
            if (_context.Communals == null) return;

            var communal = await _context.Communals.FindAsync(id);
            if (communal == null) return;

            _context.Remove(communal);
            await _context.SaveChangesAsync();
        }

        public async Task<Communal?> GetCommunal(int id)
        {
            if (_context.Communals == null) return null;

            var communal = await _context.Communals.FindAsync(id);
            if (communal == null) return null;
            
            return communal;
        }

        public async Task<List<Communal>?> GetCommunals()
        {
            if (_context.Communals == null) return null;

            return await _context.Communals.ToListAsync();
        }

        public async Task UpdateCommunal(int id, Communal communal)
        {
            _context.Entry(communal).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
