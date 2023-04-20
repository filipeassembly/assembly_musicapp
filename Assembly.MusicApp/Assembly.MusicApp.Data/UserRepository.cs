using Assembly.MusicApp.Domain.Model;
using Assembly.MusicApp.Services.Contracts;

namespace Assembly.MusicApp.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _list;

        public UserRepository()
        {
            _list = new List<User>();
            _list.Add(new User()
            {
                Id = 1,
                Name = "Filipe"
            });
        }

        public List<User> GetAll()
        {
            return new List<User>(_list);
        }

        public bool Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                return false;
            }

            foreach (var user in _list)
            {
                if (user.Account.Username == username && user.Account.Password == password)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
