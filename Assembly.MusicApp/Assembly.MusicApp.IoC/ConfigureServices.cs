using Microsoft.Extensions.DependencyInjection;

namespace Assembly.MusicApp.IoC
{
    public static class ConfigureServices
    {

        public static void Configure(IServiceCollection serviceCollection)
        {
            // Add services to the container.
           serviceCollection.AddScoped<IUserService, UserService>();
            serviceCollection.AddScoped<IUserRepository, UserRepo>();
            serviceCollection.AddScoped<IAccountService, AccountService>();

        }
    }
}
