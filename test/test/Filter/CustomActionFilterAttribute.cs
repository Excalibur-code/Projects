using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace test.Filter
{
    public class CustomActionFilterAttribute : ActionFilterAttribute
    {

        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var routdata = context.RouteData;
            var action = routdata.Values["action"];
            var controller = routdata.Values["controller"];
            Debug.Write(string.Format("Controller: {0} Action: {1} ", controller, action), "Log from Async Action Filter OnActionExecutionAsync: ");
            _ = await next();
        }
    }
}
