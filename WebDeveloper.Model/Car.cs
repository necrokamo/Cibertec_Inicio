using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Resources;

namespace WebDeveloper.Model
{
    public class Car
    {
        public int Id { get; set; }
       [Display(Name = "Car_Brand",ResourceType =typeof(Resource))]
        [Required(ErrorMessage = "The Brand is required")]
        public string Brand { get; set; }
        [Display(Name = "Car_Model",ResourceType =typeof(Resource))]
        [Required(ErrorMessage = "The Model is required")]
        public string Model { get; set; }
        [Display(Name = "Motor (Motor)")]
        [Required(ErrorMessage = "The Motor serial is required")]
        public string Motor { get; set; }
        [Display(Name = "Color (Color)")]
        [Required(ErrorMessage = "The color is required")]
        public string Color { get; set; }

        [Display(Name = "Shipping Date(Fecha de Embarque)")]
        public DateTime? ShippingDate { get; set; }
    }
}
