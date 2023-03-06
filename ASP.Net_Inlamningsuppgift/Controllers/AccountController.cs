using ASP.Net_Inlamningsuppgift.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;


namespace ASP.Net_Inlamningsuppgift.Controllers
{
    [Authorize]

    public class AccountController : Controller
    {
        private readonly UserService _userService;
        private readonly SignInManager<IdentityUser> _signinmanager;

        public AccountController(UserService userService, SignInManager<IdentityUser> signinmanager)
        {
            _userService = userService;
            _signinmanager = signinmanager;
        }



        public async Task<IActionResult> Index()
        {
            var id = @User.FindFirst("userid").Value;
            var userAccount = await _userService.GetUserAccountAsync(id);
            
            return View(userAccount);
        }

        public async Task<IActionResult> Logout()
        {
            if(_signinmanager.IsSignedIn(User))
            {
                await _signinmanager.SignOutAsync();
            }
            return LocalRedirect("/");
        }
    }
}
