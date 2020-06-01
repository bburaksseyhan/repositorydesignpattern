using Domain;

namespace Infrastructure.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IBaseRepository<Person> PersonRepository { get; }

        IBaseRepository<Department> DepartmentRepository { get; }
    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly PatternDbContext _context;
        public UnitOfWork(PatternDbContext context)
        {
            _context = context;
        }

        private IBaseRepository<Person> _personRepository;
        public IBaseRepository<Person> PersonRepository
        {
            get
            {
                if (_personRepository == null)
                {
                    _personRepository = new PersonRepository(_context);
                }

                return _personRepository;
            }
        }

        private IBaseRepository<Department> _departmentRepository;
        public IBaseRepository<Department> DepartmentRepository
        {
            get
            {
                if (_departmentRepository == null)
                {
                    _departmentRepository = new DepartmentRepository(_context);
                }

                return _departmentRepository;
            }
        }
    }
}
