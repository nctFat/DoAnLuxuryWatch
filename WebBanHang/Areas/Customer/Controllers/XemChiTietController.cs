using Microsoft.AspNetCore.Mvc;
using WebBanHang.Models;

namespace WebBanHang.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class XemChiTietController : Controller
    {
        private readonly ApplicationDbContext _db;
        public XemChiTietController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult XemChiTietDongHo(int id)
        {
            var dongHo = _db.Products.Find(id);

            ViewBag.DongHo = dongHo;

            return View("XemChiTietDongHo");
        }
    }
}
