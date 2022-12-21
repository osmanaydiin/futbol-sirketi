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
        [HttpGet]
        public IActionResult KitapGet(int id)
        {
            List<SelectListItem> kategoriler = (from y in dbck.Kategoriler.ToList()
                                                select new SelectListItem
                                                {
                                                    Text = y.KtgTuru,
                                                    Value = y.KtgId.ToString()
                                                }).ToList();
            ViewBag.kt1 = kategoriler;

            var x = kitapRepository.TGet(id);
            Kitap k1 = new Kitap()
            {
                KitapId = x.KitapId,
                KitapSayfa = x.KitapSayfa,
                KitapAdi = x.KitapAdi,
                KitapResimUrl = x.KitapResimUrl,
                KitapHakkinda = x.KitapHakkinda,
                KtgId= x.KtgId,
                KitapDurum = x.KitapDurum

            };
            return View(k1);
        }

        [HttpPost]
        public IActionResult KitapGuncelle(Kitap k)
        {
            var x = kitapRepository.TGet(k.KitapId);
            x.KitapAdi = k.KitapAdi;
            x.KitapSayfa = k.KitapSayfa;
            x.KitapHakkinda = k.KitapHakkinda;
            x.KitapResimUrl = k.KitapResimUrl;
            x.Kategori = k.Kategori;
            x.KtgId = k.KtgId;
            x.KitapDurum = true;
            kitapRepository.TUpdate(x);
            return RedirectToAction("Index");
        }

        public IActionResult KitapSil(int id)
        {
            var x = kitapRepository.TGet(id);
            x.KitapDurum = false;
            kitapRepository.TUpdate(x);
            return RedirectToAction("Index");

        }
    }
}
