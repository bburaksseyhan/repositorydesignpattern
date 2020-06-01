using Domain;

namespace Infrastructure.Repositories
{
    public class PersonRepository : GenericRepository<Person>
    {
        public PersonRepository(PatternDbContext patternDbContext) : base(patternDbContext)
        {
        }
    }
}
