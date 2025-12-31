using EmployeeManagementActivity.Model;
using EmployeeManagementActivity.Repository;
using EmployeeManagementActivity.Services;
using Microsoft.EntityFrameworkCore;
using System;

namespace EmployeeManagementActivity.Extensions
{
    public static class ApplicationServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<EmployeeRepository>();
            services.AddScoped<EmployeeServices>();
            return services;
        }
        
    }
}
