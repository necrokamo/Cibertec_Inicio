using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class CarData: BaseDataAccess<Car>
    {
        public Car GetClientById(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return GetList().Where(c => c.Id == id).FirstOrDefault();
            }
        }
    }
}
