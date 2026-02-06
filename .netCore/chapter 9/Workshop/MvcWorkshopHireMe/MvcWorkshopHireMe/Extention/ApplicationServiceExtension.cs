using Microsoft.EntityFrameworkCore;
using MvcWorkshopHireMe.Helper;
using MvcWorkshopHireMe.Interface;
using MvcWorkshopHireMe.Models;
using MvcWorkshopHireMe.Repository;
using MvcWorkshopHireMe.Services;



namespace MvcWorkshopHireMe.Extention
{
    public static  class ApplicationServiceExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<IPublicService, PublicService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IJobService, JobService>();

            services.AddScoped<IJobRepository, JobRepository>();

            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}
