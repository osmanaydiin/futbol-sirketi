using deneme2.Models;
using deneme2.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace deneme2.Controllers
{
    public class KategoriController : Controller
    {
        KategoriRepository kategoriRepository = new KategoriRepository();
        public IActionResult Index()
        {
            return View(kategoriRepository.TList());
        }
        [HttpGet]
        public IActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult KategoriEkle(Kategori ktg)
        {
            
            kategoriRepository.TAdd(ktg);
            return RedirectToAction("Index");
        }
        public IActionResult KategoriGet(int id)
        {
            var x = kategoriRepository.TGet(id);
            Kategori ktg = new Kategori()
            {
                KtgId = x.KtgId,
                KtgTuru = x.KtgTuru,

            };
            return View(ktg);
        }
        [HttpPost]
        public IActionResult KategoriGuncelle(Kategori k)
        {
            var x = kategoriRepository.TGet(k.KtgId);
            x.KtgTuru = k.KtgTuru;
            x.KtgDurum = true;
            kategoriRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
        public IActionResult KategoriSil(int id)
        {
            var x = kategoriRepository.TGet(id);
            x.KtgDurum = false;
            kategoriRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
    }
}
