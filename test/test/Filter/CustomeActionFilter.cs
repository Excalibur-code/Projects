using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace test.Filter
{
    public class CustomeActionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            var routdata = context.RouteData;
            var action = routdata.Values["action"];
            var controller = routdata.Values["controller"];
            Debug.Write(string.Format("Controller: {0} Action: {1} ", controller, action), "Log from Action Filter OnActionExecuted: ");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var routdata = context.RouteData;
            var action = routdata.Values["action"];
            var controller = routdata.Values["controller"];
            Debug.Write(string.Format("Controller: {0} Action: {1} ", controller, action), "Log from Action Filter OnActionExecuting: ");
        }
    }
}
