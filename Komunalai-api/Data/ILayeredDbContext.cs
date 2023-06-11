using Komunalai_api.Models;

namespace Komunalai_api.Data
{
    public interface ILayeredDbContext
    {
        Task AddCommunal(Communal communal);
        Task DeleteCommunal(int id);
        Task<Communal?> GetCommunal(int id);
        Task<List<Communal>?> GetCommunals();
        Task UpdateCommunal(int id, Communal communal);
    }
}
