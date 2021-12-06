namespace RepositoryPattern.SampleProject
{
    public interface IRepository<TEntity> : IQueryable<TEntity>, IAsyncEnumerable<TEntity> where TEntity : EntityBase
    {
        Task<TEntity> GetByIdAsync(long id, CancellationToken cancellationToken);
        Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken);
        TEntity Update(TEntity entity);
        void Delete(TEntity entity);
        Task DeleteAsync(long id, CancellationToken cancellationToken);
    }
}
