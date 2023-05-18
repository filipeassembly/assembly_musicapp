using Assembly.MusicApp.Services.Contracts;
using Assembly.MusicApp.Services.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assembly.MusicApp.WebApp.Pages
{
    public class FormsModel : PageModel
    {
        private readonly IUserService _userService;

        public FormsModel(IUserService userService)
        {
            this._userService = userService;
        }

        public void OnGet() // Init
        {
        }

        public void OnPost()
        {

        }

        public IActionResult OnPostSubmitForm(string name, string email, string description, int age)
        {
            var userDto = new UserDto()
            {
                Name = name,
                Email = email,
                Age = age,
                Description = description,
            };
            var isSuccess = _userService.Add(userDto);

            return RedirectToPage(isSuccess ? "ThankYou" : "Error");
        }
    }
}

