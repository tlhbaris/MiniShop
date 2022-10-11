using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniShop.Entity;

namespace MiniShop.Data.Abstract
{
    public interface IProductRepository:IRepository<Product>
    {   
        //Bu sadece Product entitymizi ilgilendiren işlemleri barındırıyor.

        
    }
}
