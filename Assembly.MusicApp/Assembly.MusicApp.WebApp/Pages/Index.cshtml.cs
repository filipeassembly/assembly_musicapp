using Assembly.MusicApp.Services.Contracts;
using Assembly.MusicApp.Services.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assembly.MusicApp.WebApp.Pages
{
    public class IndexModel : PageModel // ViewModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IUserService _userService;
        public List<UserDto> Users { get; set; }


        public IndexModel(ILogger<IndexModel> logger, IUserService userService)
        {
            _logger = logger;
            this._userService = userService;

        }

        public void OnGet()
        {
            Users = _userService.GetAll();
            //return OkResult("");
            //return RedirectToPage("ThankYou");
        }

        public void OnPost()
        {
            
        }
    }
}