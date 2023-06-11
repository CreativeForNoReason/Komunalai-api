using Komunalai_api.Models;
using Microsoft.EntityFrameworkCore;

namespace Komunalai_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Communal> Communals { get; set; }
    }
}
