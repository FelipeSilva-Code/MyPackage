
public static class ApiStartup
{
    public static IServiceCollection ApiRegister(this IServiceCollection services)
    {
        services.DomainRegister();
        return services;
    }
}
