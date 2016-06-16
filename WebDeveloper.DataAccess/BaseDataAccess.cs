﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WebDeveloper.DataAccess
{
    public class BaseDataAccess<T>: IDataAccess<T> where T:class
    {
        public int Add(T entity)
        {
            using (var dbContext=new WebContextDb())
            {
                dbContext.Entry(entity).State = EntityState.Added;
                return dbContext.SaveChanges();
            }
            //throw new NotImplementedException();
        }
        public int Delete(T entity)
        {
            using (var dbContext = new WebContextDb())
            {
                dbContext.Entry(entity).State = EntityState.Deleted;
                return dbContext.SaveChanges();
            }
            throw new NotImplementedException();
        }
        public List<T> GetList()
        {
            using (var dbContext = new WebContextDb())
            {

                return dbContext.Set<T>().ToList();
            }
            //throw new NotImplementedException();
        }
        public int Update(T entity)
        {
            using (var dbContext = new WebContextDb())
            {
                dbContext.Entry(entity).State = EntityState.Modified;
                return dbContext.SaveChanges();
            }
            //throw new NotImplementedException();
        }

    }
}
