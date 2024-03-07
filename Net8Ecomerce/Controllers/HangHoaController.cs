using Microsoft.AspNetCore.Mvc;

namespace Net8Ecomerce.Controllers
{
    public class HangHoaController : Controller
    {
        public IActionResult Index(int? loai)
        {
            return View();
        }
    }
}
