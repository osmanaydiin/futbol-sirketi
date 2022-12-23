using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using takim1.Models;
using takim1.Repositories;

namespace takim1.Controllers
{
    public class FutbolcuController : Controller
    {
        Context c = new Context();
        FutbolcuRepository futbolcuRepository = new FutbolcuRepository();
        public IActionResult Index()
        {
            return View(futbolcuRepository.TList("Takim"));
        }
        [HttpGet]
        public IActionResult FutbolcuEkle() 
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
        public IActionResult FutbolcuEkle(Futbolcu f)
        {
            futbolcuRepository.TAdd(f);
            return RedirectToAction("Index");
        }
        public IActionResult FutbolcuSil(int id)
        {
            futbolcuRepository.TRemove( new Futbolcu { FutbolcuId = id});
            return RedirectToAction("Index");
        }
    }
}
