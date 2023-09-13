using dotnetapplication.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace dotnetapplication.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> opts) :base(opts)
        {
            
        }

        public DbSet<Post> Post { get; set; }
    }
}
