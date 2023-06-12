using Komunalaiapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Komunalaiapi.Repositories
{
    public interface ICommunalRepository
    {
        Task AddCommunal(Communal communal);
        Task DeleteCommunal(int id);
        Task<Communal?> GetCommunal(int id);
        Task<List<Communal>?> GetCommunals();
        Task UpdateCommunal(int id, Communal communal);
    }
}
