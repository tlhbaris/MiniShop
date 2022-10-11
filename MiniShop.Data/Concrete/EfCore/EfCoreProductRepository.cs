using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Abstract;
using MiniShop.Entity;

namespace MiniShop.Data.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product, MiniShopContext>,IProductRepository
    {
        
    }
}