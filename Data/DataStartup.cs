using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class DataStartup
{

    public static IServiceCollection DataRegister(this IServiceCollection services)
    {
        services.AddDbContext<MySQLDBContext>((service, options) =>
        {
            var configuration = service.GetRequiredService<IConfiguration>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        });


        return services;
    }
}

