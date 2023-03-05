using ASP.Net_Inlamningsuppgift.Models.Products;
using ASP.Net_Inlamningsuppgift.Services;
using ASP.Net_Inlamningsuppgift.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Inlamningsuppgift.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductService _productservice;

        public HomeController(ProductService productservice)
        {
            _productservice = productservice;
        }

        public async Task<IActionResult> Index()
        {
           var productscardmodel = await _productservice.GetAllAsync();
            

            return View(productscardmodel);
        }
    }
}
