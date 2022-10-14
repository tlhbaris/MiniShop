using MiniShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Abstract
{
    public interface IProductService
    {
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
        Product GetById(int id);
        List<Product> GetAll();
        List<Product> GetHomePageProducts();
        Product GetProductDetails(string url);
        List<Product> GetProductsByCategory(string category);
        List<Product> GetSearchResult(string searchString);
    }
}
