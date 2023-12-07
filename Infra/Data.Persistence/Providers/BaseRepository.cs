using Data.Persistence.Contracts;
using Data.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Data.Persistence.Providers
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext context;

        protected BaseRepository(AppDbContext context)
        {
            this.context = context ?? throw new ArgumentNullException("context", "db context can't be null");
        }

        public virtual void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public virtual void Update(T entity)
        {
            context.Set<T>().Update(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            context.Set<T>().AddRange(entities);
        }

        public virtual async Task AddAsync(T entity)
        {
            await context.Set<T>().AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await context.Set<T>().AddRangeAsync(entities);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return context.Set<T>().Where(expression);
        }

        public async Task<T?> FirstOrDefault(Expression<Func<T, bool>> expression)
        {
            return await context.Set<T>().Where(expression).FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression)
        {
            return await context.Set<T>().Where(expression).ToListAsync();
        }

        public async Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> expression)
        {
            return await context.Set<T>().Where(expression).FirstOrDefaultAsync();
        }

        public T SingleOrDefault(Expression<Func<T, bool>> expression)
        {
            return context.Set<T>().Where(expression).SingleOrDefault();
        }
        public async Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> expression)
        {
            return await context.Set<T>().Where(expression).SingleOrDefaultAsync();
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression)
        {
            return await context.Set<T>().Where(expression).ToListAsync();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public async Task<int> Count(Expression<Func<T, bool>> expression)
        {
            return await context.Set<T>().Where(expression).CountAsync();
        }

        public void Remove(string id)
        {
            var entityToDelete = context.Set<T>().Find(id);
            if (entityToDelete != null)
            {
                context.Set<T>().Remove(entityToDelete);
            }
        }

        public void Remove(int id)
        {
            var entityToDelete = context.Set<T>().Find(id);
            if (entityToDelete != null)
            {
                context.Set<T>().Remove(entityToDelete);
            }
        }

        public void Remove(T entityToDelete)
        {
            if (entityToDelete != null)
            {
                context.Set<T>().Remove(entityToDelete);
            }
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            context.Set<T>().RemoveRange(entities);
        }

        public async Task<int> SaveAsync()
        {
            return await context.SaveChangesAsync();
        }


        public async Task<IEnumerable<T>> FetchAndOrderBy<TKey>(Expression<Func<T, bool>> expression, Expression<Func<T, TKey>> orderByExpression)
        {
            return await context.Set<T>().Where(expression).OrderBy(orderByExpression).ToListAsync();
        }
        public async Task<IEnumerable<T>> FetchAndOrderByDescending<TKey>(Expression<Func<T, bool>> expression, Expression<Func<T, TKey>> orderByExpression)
        {
            return await context.Set<T>().Where(expression).OrderByDescending(orderByExpression).ToListAsync();
        }
        public IQueryable<T> Queryable()
        {
            return context.Set<T>().AsQueryable();
        }
        public IQueryable<T> Queryable(Expression<Func<T, bool>> expression)
        {
            return context.Set<T>().Where(expression).AsQueryable();
        }

        public IQueryable<T> ExecuteSQLCommand(FormattableString query)
        {
            var res = context.Set<T>().FromSql(query);
            return res;
        }
    }
}