using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MiniShop.WebUI.Controllers
{
    public class HomeController : Controller
    {
    

        public IActionResult Index()
        {
            

            //Biz burada direkt veri tabanına erişmek ile ilgili kod yazmıyoruz.
            //Business katmanındaki ilgili ürünlerin getirme metodunu çalıştır.
            return View();
        }

        
    }
}