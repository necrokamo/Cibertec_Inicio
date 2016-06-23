using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebDeveloper.Helper
{
    public static class CustomHelper
    {
        public static IHtmlString DisplayPriceStatic(double price)
        {
            if (price == 0) {
                return new HtmlString("Free!!!");
            }
            else
            {
                return new HtmlString(price.ToString());
            }
          
        }


        public static IHtmlString PrDisplayPriceStatic(double price)
        {
            var result = string.Empty;
            if (price == 0)
                result = "<span>Free!!!</span>";
            else
                result = $"<span>{price}</span>";
            return new HtmlString(result);
        }

        public static IHtmlString DisplayPriceExtension(this HtmlHelper helper, double price)
        {
            var result = string.Empty;
            if (price == 0)
                result = "<span>Free!!!</span>";
            else
                result = $"<span>{price}</span>";
            return new HtmlString(result);
        }

        //Refactorizado
        private static string GetHtmlForDate(DateTime? dFecha)
        {
            return dFecha == null ? $"<span>{DateTime.Now.ToString("dd/mm/yyyy")}</span>" : $"<span>{dFecha.Value.ToString("dd/mm/yyyy")}</span>";
            //return dFecha.HasValue ? $"<span>{DateTime.Now.ToString("dd-mm-yyyy")}</span>" : $"<span>{dFecha.Value.ToString("dd-mm-yyyy")}</span>";
        }
        public static IHtmlString DisplayDateOrNullStatic(DateTime? Ndate)
        {
            //var sender = string.Empty;
            //if (Ndate == null)
            //    sender = $"<span>{@DateTime.Now}</span>";
            //else
            //    sender = $"<span>{Ndate}</span>";
            //return new HtmlString(sender);
            //refactorizado
            return new HtmlString(GetHtmlForDate(Ndate));
        }

        public static IHtmlString DisplayDateOrNullExtension(this HtmlHelper helper, DateTime? nFecha)
        {
            var sender = string.Empty;
            if (nFecha == null)
                sender = $"<span>{@DateTime.Now}</span>";
            else
                sender = $"<span>{nFecha}</span>";
            return new HtmlString(sender);
        }

       
            

    }
}
