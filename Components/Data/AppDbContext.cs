using EFCORE.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCORE.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students => Set<Student>();
    }
}
