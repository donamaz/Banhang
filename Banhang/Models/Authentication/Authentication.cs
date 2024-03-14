using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Banhang.Models.Authentication
{
    public class Authentication:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if(context.HttpContext.Session.GetString("taikhoan")==null)
            {
                context.Result=new RedirectToRouteResult(new RouteValueDictionary
                {
                    {"Controller","Acces" },
                    {"Action","Login" }
                });
            } 
        }
    }
}
