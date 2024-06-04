using Microsoft.Extensions.DependencyInjection;
using prj.Data.Implementation;
using prj.Data.Interface;

namespace prj.Data
{
    public static class prjRepositoryInjection
    {
        public static IServiceCollection AddRepositories (this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();    
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            return services;
 
            
        }
    }
}
