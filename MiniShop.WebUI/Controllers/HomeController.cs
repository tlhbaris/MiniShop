using Microsoft.AspNetCore.Mvc;
using MiniShop.WebUI.Models;
using MiniShop.WebUI.ViewModels;
using System.Diagnostics;

namespace MiniShop.WebUI.Controllers
{
    public class HomeController : Controller
    {
    

        public IActionResult Index()
        {
            ViewBag.Name = "Talha Barış";
            ViewBag.GreetingMessage ="Web Uygulamamıza Hoşgeldiniz";


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();// Vievs klasöründe Home adında bir alt klasör arar, onun içindede about.cshtml adında dosyayı arar.

        }

        
    }
}