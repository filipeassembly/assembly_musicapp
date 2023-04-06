using Assembly.MusicApp.Domain.Model;

namespace Assembly.MusicApp.Data
{
    public interface IUserRepository
    {
        List<User> GetAll();
    }
}
