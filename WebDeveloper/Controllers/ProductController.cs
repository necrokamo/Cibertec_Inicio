using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private ProductData _product;

        public ProductController(ProductData product)
        {
            _product = product;
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}