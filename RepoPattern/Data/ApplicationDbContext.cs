using Microsoft.EntityFrameworkCore;
using RepoPattern.Models;

namespace RepoPattern.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<UserDetails> UserDetails { get; set; }
    }
}
