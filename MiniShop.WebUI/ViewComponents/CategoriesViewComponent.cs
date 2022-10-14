/* Burası kendi başına yani herhangi bir viewe bağımlı kalmadan(ilgili viewe model olarak gönderilmesine gerek olmadan)
kategorileri bir liste halindee veri tabanından çekecek*/


using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;

namespace MiniShop.WebUI.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        private ICategoryService _categoryService;

        public CategoriesViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        
        public IViewComponentResult Invoke(){
            if (RouteData.Values["category"]!=null)
            {
                ViewBag.SelectedCategory = RouteData.Values["category"];
            }
            
            return View(_categoryService.GetAll());
        }
    }
}