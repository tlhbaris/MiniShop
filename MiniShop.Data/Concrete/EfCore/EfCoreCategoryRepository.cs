using MiniShop.Data.Abstract;
using MiniShop.Entity;

namespace MiniShop.Data.Concrete.EfCore
{
    public class EfCoreCategoryRepository: EfCoreGenericRepository<Category,MiniShopContext>, ICategoryRepository
    {
        
    }
}