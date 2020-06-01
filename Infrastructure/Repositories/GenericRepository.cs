using Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Infrastructure.Repositories
{
    public class GenericRepository<T> : IBaseRepository<T> where T : class
    {
        protected PatternDbContext _patternDbContext;
        public GenericRepository(PatternDbContext patternDbContext)
        {
            _patternDbContext = patternDbContext;
        }

        public T Add(T entity)
        {
            return _patternDbContext.Add(entity).Entity;
        }

        public IEnumerable<T> All()
        {
            return _patternDbContext.Set<T>().ToList();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _patternDbContext.Set<T>().AsQueryable().Where(predicate).ToList();
        }

        public T Get(int id)
        {
            return _patternDbContext.Find<T>();
        }

        public void SaveChanges()
        {
            _patternDbContext.SaveChanges();
        }

        public T Update(T entity)
        {
            return _patternDbContext.Update(entity).Entity;
        }
    }
}
