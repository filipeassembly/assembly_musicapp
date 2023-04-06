using Assembly.MusicApp.Data;
using Assembly.MusicApp.Domain.Model;

namespace Assembly.MusicApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }
    }
}
