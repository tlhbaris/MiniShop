using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.WebUI.Models;

namespace MiniShop.WebUI.Controllers
{
    public class MiniShopController : Controller
    {

        private IProductService _productService;


        public MiniShopController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Details(string url)
        {
            if (url==null)
            {
                return NotFound();
            }
            //Bu aşamada benim gidip ProductService üzerinden ilgili ürünü çekip getiricek methoda ihtiyacım var. Ama henüz o method yok.

            var product = _productService.GetProductDetails(url);
            if(product==null)
            {
                return NotFound();
            }

            var productDetail = new ProductDetailModel()
            {
                Product = product,
                Categories = product
                        .ProductCategories
                        .Select(pc => pc.Category)
                        .ToList()

            };


            return View(productDetail);
        }
    }
}
