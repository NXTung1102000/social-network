using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using Model;

namespace Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DatabaseContext _context;
        private readonly DbSet<T> _db;

        public GenericRepository(DatabaseContext context)
        {
            _context = context;
            _db = _context.Set<T>();
        }

        public async Task<IList<T>> GetAllAsync(
            Expression<Func<T, bool>>? expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null
        )
        {
            IQueryable<T> query = _db;

            if (expression != null)
            {
                query = query.Where(expression);
            }

            if (include != null)
            {
                query = include(query);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }
            return await query.AsNoTracking().ToListAsync();
        }

        public async Task<PagedResponse<T>> GetPagedList(
            RequestParams requestParams,
            Expression<Func<T, bool>>? expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null)
        {
            IQueryable<T> query = _db;

            if (expression != null)
            {
                query = query.Where(expression);
            }

            if (include != null)
            {
                query = include(query);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            var data = await query.AsNoTracking()
            .Skip((requestParams.PageNumber - 1) * requestParams.PageSize)
            .Take(requestParams.PageSize).ToListAsync();
            int count = await Count(expression: expression);
            var res = new PagedResponse<T>(
                pageNumber: requestParams.PageNumber,
                pageSize: requestParams.PageSize,
                totalPages: (int)Math.Ceiling(count / (double)requestParams.PageSize),
                totalRecords: count,
                data: data
                );

            return res;
        }

        public async Task<T?> GetAsync(
            Expression<Func<T, bool>> expression,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null
        )
        {
            IQueryable<T> query = _db;
            if (include != null)
            {
                query = include(query);
            }

            return await query.AsNoTracking().FirstOrDefaultAsync(expression);
        }

        public async Task<int> Count(Expression<Func<T, bool>>? expression = null)
        {
            IQueryable<T> query = _db;

            if (expression != null)
            {
                query = query.Where(expression);
            }

            return await query.CountAsync();
        }

        public async Task InsertAsync(T entity)
        {
            // insert entity
            await _db.AddAsync(entity);
        }

        public async Task DeleteAsync(Expression<Func<T, bool>> expression)
        {
            // search -> delete entity
            var entitySearch = await GetAsync(expression);
            if (entitySearch != null)
            {
                _db.Remove(entitySearch);
            }
        }

        public async Task UpdateAsync(Expression<Func<T, bool>> expression, T entity)
        {
            // search -> update entity
            var entitySearch = await GetAsync(expression: expression);
            if (entitySearch != null)
            {
                _db.Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
            }
        }

    }
}
