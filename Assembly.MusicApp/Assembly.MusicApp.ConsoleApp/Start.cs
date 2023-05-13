using Assembly.MusicApp.Services.Contracts;

namespace Assembly.MusicApp.ConsoleApp
{
    public class Start
    {
        private readonly IUserService _userService;

        public Start(IUserService userService)
        {
            this._userService = userService;
        }

        public void Run()
        {
            Console.WriteLine(_userService.GetAll());
        }
    }
}
