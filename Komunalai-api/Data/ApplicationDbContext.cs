using Komunalai_api.Models;
using Microsoft.EntityFrameworkCore;

namespace Komunalai_api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Communal>? Communals { get; set; }
    }
}
