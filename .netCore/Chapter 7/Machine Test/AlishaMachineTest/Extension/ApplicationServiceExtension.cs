using AlishaMachineTest.Model;
using Microsoft.EntityFrameworkCore;

namespace AlishaMachineTest.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
          (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
