using Microsoft.EntityFrameworkCore;

namespace Sheffield_Car_Park_System.Services
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User>? Users { get; set; }
    }
}