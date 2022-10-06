using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Abstract
{
    public interface IRepository<T>
    {   
        //Bu interface/repository tüm entitlerimizi ilgilendiren CRUD işlemlerini barındırıyor.
        List<T> GetAll();
        T GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
