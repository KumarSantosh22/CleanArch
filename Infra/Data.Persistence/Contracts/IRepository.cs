using System.Linq.Expressions;

namespace Data.Persistence.Contracts
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        Task<IEnumerable<T>> GetAllAsync();

        IEnumerable<T> Find(Expression<Func<T, bool>> expression);

        void Add(T entity);
        void Update(T entity);

        void AddRange(IEnumerable<T> entities);

        void Remove(string entityId);

        void Remove(int id);

        void Remove(T entityToDelete);

        void RemoveRange(IEnumerable<T> entities);

        Task<T> FirstOrDefault(Expression<Func<T, bool>> expression);

        T SingleOrDefault(Expression<Func<T, bool>> expression);

        Task<int> SaveAsync();

        Task<int> Count(Expression<Func<T, bool>> expression);

        Task<T?> GetByIdAsync(int id);

        Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> expression);

        Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> expression);

        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression);

        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression);

        Task AddAsync(T entity);

        Task AddRangeAsync(IEnumerable<T> entities);

        Task<IEnumerable<T>> FetchAndOrderBy<TKey>(Expression<Func<T, bool>> expression, Expression<Func<T, TKey>> orderByExpression);
        Task<IEnumerable<T>> FetchAndOrderByDescending<TKey>(Expression<Func<T, bool>> expression, Expression<Func<T, TKey>> orderByExpression);

        IQueryable<T> Queryable();

        IQueryable<T> Queryable(Expression<Func<T, bool>> expression);

        IQueryable<T> ExecuteSQLCommand(FormattableString query);
    }
}
