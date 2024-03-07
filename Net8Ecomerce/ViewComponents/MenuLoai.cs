using Microsoft.AspNetCore.Mvc;
using Net8Ecomerce.Data;
using Net8Ecomerce.Models;
using Net8Ecomerce.ViewModels;

namespace Net8Ecomerce.ViewComponents
{
    public class MenuLoai : ViewComponent
    {
        private readonly Hshop2023Context db;

        public MenuLoai(Hshop2023Context context) => db = context;

        public IViewComponentResult Invoke()
        {
            var data = db.Loais.Select(lo => new MenuLoaiVM
            {
                MaLoai = lo.MaLoai,
                TenLoai = lo.TenLoai,
                SoLuong = lo.HangHoas.Count
            }).OrderBy(p => p.TenLoai);

            return View(data); // Default.cshtml
                               //return View("Default", data);
        }
    }
}
