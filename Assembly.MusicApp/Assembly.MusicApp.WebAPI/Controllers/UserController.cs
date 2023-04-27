using Assembly.MusicApp.Domain.Model;
using Assembly.MusicApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

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
        public IActionResult Login(AccountRequest request)
        {
            if (ModelState.IsValid)
            {
                return BadRequest();
            }

            new AccountRequest()
            {
                UserName = "",
                Age = -23
            }
            return _accountService.Login(request.UserName, request.Password);
        }
    }
}


public class AccountRequest
{
    [Required]
    [MaxLength(255)]

    public string UserName { get; set; }
    public string Password { get; set; }
}

/*
 * 
 * {
 *  "usename": "fcoelho",
 *  "password" : "12345"
 * }
 * 
 * /