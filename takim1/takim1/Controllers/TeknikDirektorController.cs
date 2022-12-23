using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using takim1.Models;
using takim1.Repositories;

namespace takim1.Controllers
{
    public class TeknikDirektorController : Controller
    {
        Context c = new Context();
        TeknikDirektorRepository teknikDirektorRepository = new TeknikDirektorRepository();
        public IActionResult Index()
        {
            return View(teknikDirektorRepository.TList("Takim"));
        }
        [HttpGet]
        public IActionResult TeknikDirektorEkle()
        {
            List<SelectListItem> takimlar = (from x in c.Takimlar.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.TakimAdi,
                                                 Value = x.TakimId.ToString()
                                             }).ToList();
            ViewBag.kt1 = takimlar;
            return View();
        }
        [HttpPost]
        public IActionResult TeknikDirektorEkle(TeknikDirektor f)
        {
            teknikDirektorRepository.TAdd(f);
            return RedirectToAction("Index");
        }
        public IActionResult TeknikDirektorSil(int id)
        {
            teknikDirektorRepository.TRemove(new TeknikDirektor { TeknikDirektorId = id });
            return RedirectToAction("Index");
        }
    }
}
