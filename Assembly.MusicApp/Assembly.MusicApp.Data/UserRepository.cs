using Assembly.MusicApp.Domain.Model;

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
    }
}
