using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using Model;
namespace Repository
{
    public interface IGenericRepository<T> where T : class
    {
        public Task<IList<T>> GetAllAsync(
            Expression<Func<T, bool>>? expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null
        );
        public Task<PagedResponse<T>> GetPagedList(
            RequestParams requestParams,
            Expression<Func<T, bool>>? expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null
            );
        public Task<T?> GetAsync(
            Expression<Func<T, bool>> expression,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null
        );
        public Task<int> Count(Expression<Func<T, bool>>? expression = null);
        public Task InsertAsync(T entity);
        public Task DeleteAsync(Expression<Func<T, bool>> expression);
        public Task UpdateAsync(Expression<Func<T, bool>> expression, T entity);
    }
}
