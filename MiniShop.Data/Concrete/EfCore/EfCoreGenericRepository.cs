using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Concrete.EfCore
{
    public class EfCoreGenericRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class
        where TContext: DbContext, new()
    {
        public List<TEntity> GetAll()
        {
            using (var context = new TContext())
            {
                //context.Product ya da context.Category gibi(SET methodu)
                return context.Set<TEntity>().ToList(); 
            }
        }



        public void Create(TEntity entity)
        {
            using(var context =  new TContext())
            {
                context.Set<TEntity>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            using(var context = new TContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public void Update(TEntity entity)
        {
            using(var context = new TContext())
            {
                context.Entry(entity).State=EntityState.Modified; //Sadece değişiklik yapılmış olanları yazar.
                // context.Set<TEntity>().Update(entity);//Bu tüm alanları yeniden yazar.
                context.SaveChanges();
            }
        }
    }
}
