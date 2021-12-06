namespace RepositoryPattern.SampleProject
{
    public static class ServiceExtensions
    {
        public static IServiceCollection DataAccessService<TDbContext>(this IServiceCollection services) where TDbContext : DbContext
        {
            services.AddDbContext<TDbContext>(conf => conf.UseSqlServer("Server=myServerName,myPortNumber;Database=myDataBase;User Id=myUsername;Password=myPassword;"));
            services.AddScoped<IUnitOfWork<TDbContext>, UnitOfWork<TDbContext>>();
            return services;
        }
    }
}
