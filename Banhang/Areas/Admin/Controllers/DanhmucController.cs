using Banhang.Models;
using Microsoft.AspNetCore.Mvc;

namespace Banhang.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    [Route("amidn/homeadmin")]
    public class DanhmucController : Controller
    {
        WBNoiThatContext db =new WBNoiThatContext();
        [Route("")]
        [Route("Danhmuc")]
        public IActionResult Index()
        {
            var lsp = db.DanhMucs.ToList();
            return View(lsp);
        }
        
    }
}
