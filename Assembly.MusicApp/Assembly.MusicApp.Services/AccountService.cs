using Assembly.MusicApp.Services.Contracts;

namespace Assembly.MusicApp.Services
{
    public class AccountService: IAccountService
    {
        private readonly IUserRepository _userRepository;

        public AccountService(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public bool Login(string username, string password)
        {
            if(string.IsNullOrEmpty(username))
            {
                return false;
            }
            
            return _userRepository.Login(username, password);
        }
    }
}
