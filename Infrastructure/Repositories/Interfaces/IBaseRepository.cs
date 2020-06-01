using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Infrastructure.Repositories.Interfaces
{
    public interface IBaseRepository<T>
    {
        T Add(T entity);

        T Update(T entity);

        T Get(int id);

        IEnumerable<T> All();

        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        void SaveChanges();
    }
}
