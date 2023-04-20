using Assembly.MusicApp.Domain.Model;

namespace Assembly.MusicApp.Services.Contracts
{
    public interface IUserRepository
    {
        List<User> GetAll();
        bool Login(string username, string password);
    }
}
