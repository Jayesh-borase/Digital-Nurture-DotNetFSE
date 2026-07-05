using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EmployeeManagementApi.Filters
{
    public class CustomExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            File.AppendAllText(
                "ExceptionLog.txt",
                $"[{DateTime.Now}] {context.Exception}\n\n"
            );

            context.Result = new ObjectResult("An internal server error occurred.")
            {
                StatusCode = StatusCodes.Status500InternalServerError
            };

            context.ExceptionHandled = true;
        }
    }
}