using Komunalaiapi.Models;
using Microsoft.EntityFrameworkCore;

namespace Komunalaiapi.Data
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
