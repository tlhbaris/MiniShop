using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Data.Abstract;
using MiniShop.Entity;
using System.Diagnostics;

namespace MiniShop.WebUI.Controllers
{
    public class HomeController : Controller
    {

        private IProductService _productService;
        

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {


            //Biz burada direkt veri tabanına erişmek ile ilgili kod yazmıyoruz.
            //Business katmanındaki ilgili ürünlerin getirme metodunu çalıştır.
            //var allProduct = _productService.GetHomePageProducts();
            var allProduct = _productService.GetAll();
            return View(allProduct);
            
        }

        
    }

}