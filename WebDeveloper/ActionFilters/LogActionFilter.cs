using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebDeveloper.ActionFilters
{
    public class LogActionFilter: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
           Debug.WriteLine($"OnActionExecuting controller: {filterContext.RouteData.Values["controller"]} action: {filterContext.RouteData.Values["action"]}", "OnExecuting");
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine($"OnActionExecuted controller: {filterContext.RouteData.Values["controller"]} action: {filterContext.RouteData.Values["action"]}", "OnExecuted");
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            //Debug.WriteLine($"OnResultExecuted controller: {filterContext.RouteData.Values["controller"]} action: {filterContext.RouteData.Values["action"]}", "OnActionExecuted");
            GetMessage("OnResultExecuted", filterContext.RouteData.Values["controller"].ToString(), filterContext.RouteData.Values["action"].ToString());
        }
        

        private static void GetMessage(String tipo,String Contrlador,String Accion)
        {
            Debug.WriteLine($"{tipo} controller: {Contrlador} action: {Accion}", "Resultado");
            //return $"{tipo} controller: {Contrlador} action: {Accion}";            
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            //var controllerName = filterContext.RouteData.Values["controller"];
            //var ActionName = filterContext.RouteData.Values["action"];
            //var message = $"OnActionExecuting controller: {controllerName} action: {ActionName}";
            //Debug.WriteLine(message, "Action Filter Log");
            ShowData("OnResultExecuting", filterContext.RouteData);
        }

        private static void ShowData(string ActionMethod,RouteData routeData)
        {
            var controllerName = routeData.Values["controller"];
            var ActionName = routeData.Values["action"];
            var message = $"{ActionMethod} controller: {controllerName} action: {ActionName}";
            Debug.WriteLine(message, "Action Filter Log");
        }
    }
}
