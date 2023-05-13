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

        public User Add(User entity)
        {
            throw new NotImplementedException();
        }

        public User Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public User Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
