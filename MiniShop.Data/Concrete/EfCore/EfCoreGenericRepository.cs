﻿using MiniShop.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Concrete.EfCore
{
    public class EfCoreGenericRepository<TEntity> : IRepository<TEntity>
    {
        public List<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }



        public void Create(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
