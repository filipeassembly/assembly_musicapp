using Assembly.MusicApp.Domain.Model;
using Assembly.MusicApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assembly.MusicApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "admin")] // Roles
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IAccountService _accountService;

        public UserController(IUserService userService, IAccountService accountService)
        {
            this._userService = userService;
            this._accountService = accountService;
        }

        [HttpGet]
        public List<User> Get()
        {
            return _userService.GetAll();
        }

        [HttpPost("login")]
        public bool Login(AccountRequest request)
        {
            return _accountService.Login(request.UserName, request.Password);
        }
    }
}


public class AccountRequest
{
    public string UserName { get; set; }
    public string Password { get; set; }
}