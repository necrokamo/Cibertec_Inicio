using System;
using System.ComponentModel.DataAnnotations;
using WebDeveloper.Resources;


namespace WebDeveloper.Model
{
    public class Product
    {
        [Display(Name = "Product_Id",ResourceType =typeof(Resource))]
        public int ID { get; set; }
        [Display(Name = "Product_Name",ResourceType =typeof(Resource))]
        [StringLength(150,MinimumLength =5, ErrorMessageResourceName = "Error_Lenght", ErrorMessageResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceName ="Error_Required",ErrorMessageResourceType =typeof(Resource))]
        public string Description { get; set; }
        [Display(Name = "Product_Price",ResourceType =typeof(Resource))]
        [Required(ErrorMessageResourceName = "Error_Required", ErrorMessageResourceType = typeof(Resource))]
        
        public double Precio { get; set; }
        [Display(Name = "Product_CreationDate",ResourceType =typeof(Resource))]
        public DateTime? Fecha { get; set; }
    }
}
