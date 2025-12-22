using AneeshaMachineTestLibrary.Interface;
using AneeshaMachineTestLibrary.Model;
using AneeshaMachineTestLibrary.Repository;
using AneeshaMachineTestLibrary.Service;
using Microsoft.EntityFrameworkCore;

namespace AneeshaMachineTestLibrary.Extension;

public static class ApplicationServiceExtension
{
    public static IServiceCollection AddApplicationServices
        (this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<BookDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

        services.AddScoped<IBookService, BookService>();

        services.AddScoped<IBookRepository, BookRepository>();

        services.AddAutoMapper(typeof(AutoMapperProfile));
        return services;

    }
}
