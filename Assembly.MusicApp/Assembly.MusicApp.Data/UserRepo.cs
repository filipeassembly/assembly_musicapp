using Assembly.MusicApp.Domain.Model;
using Assembly.MusicApp.Services.Contracts;

namespace Assembly.MusicApp.Data
{
    public class UserRepo : IUserRepository
    {
        private readonly List<User> _list;
        public UserRepo()
        {
            _list = new List<User>();
            _list.Add(new User()
            {
                Id = 1,
                Name = "Yuri"
            });
        }

        public List<User> GetAll()
        {
            return new List<User>(_list);
        }
    }
}
