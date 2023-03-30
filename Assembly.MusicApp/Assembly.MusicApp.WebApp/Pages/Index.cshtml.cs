using Assembly.MusicApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assembly.MusicApp.WebApp.Pages
{
    public class IndexModel : PageModel // ViewModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IUserService _userService;

        public IndexModel(ILogger<IndexModel> logger, IUserService userService)
        {
            _logger = logger;
            this._userService = userService;
        }

        public void OnGet()
        {
            var str = _userService.GetAll();
        }
    }
}