using APISwager.Models;
using Microsoft.EntityFrameworkCore;

namespace APISwager.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options) { }

        public DbSet<Persons> Persons { get; set; }
    }
}
