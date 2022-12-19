using deneme2.Models;
using deneme2.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace deneme2.Controllers
{
    public class KitapController : Controller
    {
        DbCoreKitap dbck = new DbCoreKitap();
        KitapRepository kitapRepository = new KitapRepository();
        public IActionResult Index()
        {
            return View(kitapRepository.TList("Kategori"));
        }
        [HttpGet]
        public IActionResult KitapEkle()
        {
            List<SelectListItem> kategoriler = (from x in dbck.Kategoriler.ToList()
                                                select new SelectListItem
                                                {
                                                    Text = x.KtgTuru,
                                                    Value = x.KtgId.ToString()
                                                }).ToList();
            ViewBag.kt1 = kategoriler;
            return View();
        }
        [HttpPost]
        public IActionResult KitapEkle(Kitap k1)
        {
            kitapRepository.TAdd(k1);
            return RedirectToAction("Index");
        }
        public IActionResult KitapSil(int id)
        {
            kitapRepository.TRemove(new Kitap { KitapId = id});
            return RedirectToAction("Index");
        }
    }
}
