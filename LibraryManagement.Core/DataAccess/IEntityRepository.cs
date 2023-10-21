using LibraryManagement.Core.Entities;
using System.Linq.Expressions;

namespace LibraryManagement.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetList(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includeProperties);
        T Get(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includeProperties);
        T Add(T entity);
        T Update(T entity);
        bool Delete(T entity);
    }
}
