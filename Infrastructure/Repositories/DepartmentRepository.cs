using Domain;

namespace Infrastructure.Repositories
{
    public class DepartmentRepository : GenericRepository<Department>
    {
        public DepartmentRepository(PatternDbContext patternDbContext) : base(patternDbContext)
        {
        }
    }
}
