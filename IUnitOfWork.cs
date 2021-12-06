namespace RepositoryPattern.SampleProject
{
    public interface IUnitOfWork<TDbContext> where TDbContext : DbContext
    {
        IRepository<TEntity> GetRepositoy<TEntity>() where TEntity : EntityBase;
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
