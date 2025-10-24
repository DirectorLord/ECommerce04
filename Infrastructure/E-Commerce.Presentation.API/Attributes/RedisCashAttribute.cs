using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace E_Commerce.Presentation.API.Attributes;

public class RedisCashAttribute : ActionFilterAttribute
{
    public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        next.Invoke();
        return base.OnActionExecutionAsync(context, next);
    }
}
