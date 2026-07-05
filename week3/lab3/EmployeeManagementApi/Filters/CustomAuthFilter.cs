using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EmployeeManagementApi.Filters
{
    public class CustomAuthFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Check if Authorization header exists
            if (!context.HttpContext.Request.Headers.ContainsKey("Authorization"))
            {
                context.Result = new BadRequestObjectResult("Invalid request - No Auth token");
                return;
            }

            // Read Authorization header value
            var authToken = context.HttpContext.Request.Headers["Authorization"].ToString();

            // Check if Bearer is present
            if (!authToken.Contains("Bearer"))
            {
                context.Result = new BadRequestObjectResult("Invalid request - Token present but Bearer unavailable");
                return;
            }

            base.OnActionExecuting(context);
        }
    }
}