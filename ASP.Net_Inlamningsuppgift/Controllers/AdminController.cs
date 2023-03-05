using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Inlamningsuppgift.Controllers
{
    [Authorize(Roles = "Admin")]
   
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
