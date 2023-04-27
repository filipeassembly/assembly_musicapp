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

        public Account Add(Account entity)
        {
            throw new NotImplementedException();
        }

        public Account Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Account Delete(Account entity)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            return new List<User>(_list);
        }

        public Account GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Account Update(Account entity)
        {
            throw new NotImplementedException();
        }

        List<Account> IRepository<Account>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
