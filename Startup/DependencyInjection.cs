using Hunger.Data;

namespace Hunger.Startup;

public static class DependencyInjection
{
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddRazorPages();
        services.AddServerSideBlazor();
        services.AddSingleton<RestaurantService>();
        services.AddSingleton<RepositoryInformation>();
    }
}