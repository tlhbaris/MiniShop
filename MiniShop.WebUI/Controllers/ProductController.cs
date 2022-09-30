using Microsoft.AspNetCore.Mvc;
using MiniShop.WebUI.Models;
using MiniShop.WebUI.ViewModels;

namespace MiniShop.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

         return View();

        }
        
        public IActionResult Details()
        {
           return View();
        }
    }
}
