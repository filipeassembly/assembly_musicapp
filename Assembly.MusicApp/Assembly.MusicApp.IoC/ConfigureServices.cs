
using Assembly.MusicApp.DataMsSql;
using Assembly.MusicApp.Services;
using Assembly.MusicApp.Services.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Assembly.MusicApp.IoC
{
    public static class ConfigureServices
    {

        public static void ConfigureConsoleApp(this IServiceCollection serviceCollection)
        {
            serviceCollection.ConfigureCommon();


        }

        public static void ConfigureWebApi(this IServiceCollection serviceCollection)
        {
            // Add services to the container.
            serviceCollection.ConfigureCommon();

        }

        public static void ConfigureWebApp(this IServiceCollection serviceCollection)
        {
            serviceCollection.ConfigureCommon();

        }

        private static void ConfigureCommon(this IServiceCollection serviceCollection)
        {
            // Add services to the container.
            serviceCollection.AddScoped<IUserService, UserService>();
            serviceCollection.AddScoped<IUserService, UserService>();

            serviceCollection.AddScoped<IUserService, UserService>();
            serviceCollection.AddScoped<IUserRepository, UserRepository>();
            serviceCollection.AddScoped<IAccountService, AccountService>();
        }
    }
}
