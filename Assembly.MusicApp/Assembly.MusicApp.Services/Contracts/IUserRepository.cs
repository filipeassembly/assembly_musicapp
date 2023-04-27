using Assembly.MusicApp.Domain.Model;

namespace Assembly.MusicApp.Services.Contracts
{
    public interface IUserRepository : IRepository<User>
    {
        bool Login(string username, string password);
    }
}
