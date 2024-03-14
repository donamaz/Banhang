using Microsoft.AspNetCore.Mvc;

namespace Banhang.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    [Route("amidn/homeadmin")]
    public class AdminController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
