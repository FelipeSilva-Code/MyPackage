using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;


public static class DomainStartup
{

    public static IServiceCollection DomainRegister(this IServiceCollection services)
    {
        services.DataRegister();

        return services;
    }
}

