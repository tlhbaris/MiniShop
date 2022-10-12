using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Abstract;
using MiniShop.Entity;

namespace MiniShop.Data.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product, MiniShopContext>, IProductRepository
    {
        public List<Product> GetHomePageProducts()
        {
           using(var context = new MiniShopContext())
            {
                return context
                     .Products
                     .Where(p => p.IsApproved && p.IsHome)
                     .ToList();
            }
        }

        public Product GetProductDetails(string url)
        {
            using (var context = new MiniShopContext())
            {
                return context
                     .Products
                     .Where(p => p.Url==url)
                     .Include(pc =>pc.ProductCategories)
                     .ThenInclude(c => c.Category)
                     .FirstOrDefault();

            }
        }
    }
}