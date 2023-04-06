using Assembly.MusicApp.ConsoleApp;
using Assembly.MusicApp.Services;
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();
serviceCollection.AddSingleton<Start>();
//serviceCollection.AddSingleton<Start>(x => new Start()); // TODO: speak

serviceCollection.AddSingleton<IUserService, UserService>();
//serviceCollection.AddScoped<IUserRepository, UserRepository>();

var serviceProvider = serviceCollection.BuildServiceProvider();

var start = serviceProvider.GetService<Start>();

if (start is not null)
{
    start.Run();
}