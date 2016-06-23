using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebDeveloper.Model
{
    public class Product
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public double Precio { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
