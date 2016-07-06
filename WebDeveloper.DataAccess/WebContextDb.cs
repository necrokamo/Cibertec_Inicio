using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class WebContextDb : DbContext
    {
        public WebContextDb(): base("name=WebDeveloperConnectionString")
        {
            //agregamos el metodo setinitializer para listar la clase
            //Database.SetInitializer(new WebDeveloperInitializer());
        }
        public DbSet<Client>Clients { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Product> Products { get; set; }
        //todo lo que venga se mapea al objeto

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
