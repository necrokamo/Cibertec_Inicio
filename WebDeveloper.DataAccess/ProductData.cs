using System;
using System.Collections.Generic;
using System.Linq;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class ProductData: BaseDataAccess<Product>
    {
        public Product GetProductById(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return GetList().Where(p => p.ID == id).FirstOrDefault();
            }
        }
    }
        //public List<Product> GetFakeProducts()
        //{
        //    return new List<Product>
        //    {
        //        new Product {ID=1,Description="Cristal",Precio=3.0,Fecha=DateTime.Now },
        //        new Product {ID=2,Description="Cusqueña",Precio=4.0,Fecha=DateTime.Now },
        //        new Product {ID=3,Description="Casera",Precio=0,Fecha=DateTime.Now }
        //    };
        //}

        
    
}
