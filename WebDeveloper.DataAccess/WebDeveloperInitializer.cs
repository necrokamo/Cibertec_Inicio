using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class WebDeveloperInitializer: DropCreateDatabaseAlways<WebContextDb>
    {
        //override de la clases bases
        protected override void Seed(WebContextDb context)
        {
            var clients = new List<Client>
            {
                new Client {Name="A1", LastName="A2" },
                new Client {Name="B1", LastName="B2" },
                new Client {Name="C1", LastName="C2" },
                new Client {Name="D1", LastName="D2" },
                new Client {Name="E1", LastName="E2" },
            };

            clients.ForEach(C => context.Clients.Add(C));
            context.SaveChanges();
        }
    }
}
