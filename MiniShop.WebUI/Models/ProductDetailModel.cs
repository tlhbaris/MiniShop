using MiniShop.Entity;

namespace MiniShop.WebUI.Models
{
    public class ProductDetailModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}
