using Banhang.Models;
using Microsoft.AspNetCore.Mvc;

namespace Banhang.Controllers
{
    public class AccesController : Controller
    {
        WBNoiThatContext db = new WBNoiThatContext();
        [HttpGet]
        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("taikhoan")==null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login","Acces");
            }
           
        }
        [HttpPost]
        public IActionResult Login(Taikhoan tk)
        {
            if (HttpContext.Session.GetString("taikhoan") == null)
            {
                var t = db.Taikhoans.Where(x => x.TaiKhoan1.Equals(tk.TaiKhoan1) && x.MatKhau.Equals(tk.MatKhau)).FirstOrDefault();
                if (t != null)
                {
                    HttpContext.Session.SetString("taikhoan", t.TaiKhoan1.ToString());
                    if (t.LoaiQuyen == "user")
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    if (t.LoaiQuyen == "admin")
                    {
                        return RedirectToAction("Index", "Admin");
                    }

                }
            }
            return View();  
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.Remove("taikhoan");
            return RedirectToAction("Login", "Acces");
        }
    }
}
