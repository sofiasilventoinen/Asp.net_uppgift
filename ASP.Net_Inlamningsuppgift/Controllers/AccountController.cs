using ASP.Net_Inlamningsuppgift.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace ASP.Net_Inlamningsuppgift.Controllers
{
    [Authorize]

    public class AccountController : Controller
    {
        private readonly UserService _userService;

        public AccountController(UserService userService)
        {
            _userService = userService;
        }



        public async Task<IActionResult> Index(string id)
        {
            var userAccount = await _userService.GetUserAccountAsync(id);
            
            return View(userAccount);
        }
    }
}
