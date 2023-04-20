using Assembly.MusicApp.Data;
using Assembly.MusicApp.Domain.Model;
using Assembly.MusicApp.Services.Contracts;

namespace Assembly.MusicApp.DataMsSql
{
    internal class UserRepository : IUserRepository
    {
        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Login(string username, string password)
        {
            if(string.IsNullOrEmpty(username))
            {
                return false;
            }

            return true;
        }
    }
}
