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

        public List<Product> GetProductsByCategory(string category)
        {
            using (var context = new MiniShopContext())
            {
                List<Product> products = new List<Product>();

                if (!string.IsNullOrEmpty(category))
                {
                    products = context
                                    .Products
                                    .Include(pc => pc.ProductCategories)
                                    .ThenInclude(c => c.Category)
                                    .Where(pc => pc.ProductCategories
                                        .Any(c => c.Category.Url == category))
                                    .ToList();
                }
                else
                {
                    products = context.Products.ToList();
                }
                return products;
            }
        }

        public List<Product> GetSearchResult(string searchString)
        {
            using(var context = new MiniShopContext())
            {
                var products = context
                            .Products
                            .Where(p => p.IsApproved && (p.Name.ToLower().Contains(searchString.ToLower()) 
                            || p.Description.ToLower().Contains(searchString.ToLower()) ))
                            .ToList();
                    return products; 
            }
            
        }
    
    }
}