using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class PatternDbContext : DbContext
    {
        public PatternDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Department> Departments { get; set; }
    }
}
