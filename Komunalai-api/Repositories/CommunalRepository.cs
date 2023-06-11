using Komunalai_api.Data;
using Komunalai_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Komunalai_api.Repositories
{
    public class CommunalRepository : ICommunalRepository
    {
        private readonly ILayeredDbContext _context;

        public CommunalRepository(ILayeredDbContext context)
        {
            _context = context;
        }

        public async Task AddCommunal(Communal communal)
        {
            await _context.AddCommunal(communal);
        }

        public async Task DeleteCommunal(int id)
        {
            await _context.DeleteCommunal(id);
        }

        public async Task<Communal?> GetCommunal(int id)
        {
            return await _context.GetCommunal(id);
        }

        public async Task<List<Communal>?> GetCommunals()
        {
            return await _context.GetCommunals();
        }

        public async Task UpdateCommunal(int id, Communal communal)
        {
            await _context.UpdateCommunal(id, communal);
        }
    }
}
