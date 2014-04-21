using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace RegistrationAngular.Repository
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        ICollection<T> GetAllWhere(Expression<Func<T, bool>> filter);
        T GetWhere(Expression<Func<T, bool>> filter);
    }

    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        public abstract IQueryable<T> GetAll();

        public ICollection<T> GetAllWhere(Expression<Func<T, bool>> filter)
        {
            return this.GetAll().Where(filter).ToList();
        }

        public T GetWhere(Expression<Func<T, bool>> filter)
        {
            return this.GetAll().FirstOrDefault(filter);
        }
    }
}