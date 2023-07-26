using System.Linq.Expressions;

namespace LearnDapper.Interfaces
{
    public interface IReadRepositoryBase<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll(bool asNoTrcking=true);
        IQueryable<TEntity> GetBySpecs(Expression<Func<TEntity, bool>> predicate, bool asNoTracking = true);
        Task<TEntity?> GetByIdAsync<TId>(TId id, CancellationToken cancellationToken = default) where TId : notnull;
        Task<TEntity?> GetBySpecsAsync<Spec>(Expression<Func<TEntity,bool>>predicate,CancellationToken cancellationToken=default);
        Task<ICollection<TEntity>> ListAsync(CancellationToken cancellationToken = default);
        Task<ICollection<TEntity>> ListAsync(Expression<Func<TEntity,bool>>predicate, CancellationToken cancellationToken =default);
        Task<int> CountAsync(CancellationToken cancellationToken = default);
        Task<int> CountAsync(Expression<Func<TEntity, bool>>predicate, CancellationToken cancellationToken = default);
        Task<bool>AnyAsync(CancellationToken cancellationToken = default);
        Task<bool>AnyAsync(Expression<Func<TEntity,bool>>predicate, CancellationToken cancellationToken=default);
        IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] includiProperties);
    }
}
