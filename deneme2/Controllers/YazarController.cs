using deneme2.Models;
using deneme2.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace deneme2.Controllers
{
    public class YazarController : Controller
    {
        YazarRepository yazarRepository = new YazarRepository();
        public IActionResult Index()
        {
            return View(yazarRepository.TList());
        }
        [HttpGet]
        public IActionResult YazarEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YazarEkle(Yazar y)
        {

            yazarRepository.TAdd(y);
            return RedirectToAction("Index");
        }
        public IActionResult YazarGet(int id)
        {
            var x = yazarRepository.TGet(id);
            Yazar y1 = new Yazar()
            {
                YazarId = x.YazarId,
                YazarAdi = x.YazarAdi,
                YazarSoyadi = x.YazarSoyadi,
            };
            return View(y1);
        }
        [HttpPost]
        public IActionResult YazarGuncelle(Yazar y)
        {
            var x = yazarRepository.TGet(y.YazarId);
            x.YazarAdi = y.YazarAdi;
            x.YazarSoyadi = y.YazarSoyadi;
            x.YazarDurum = true;
            yazarRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
        public IActionResult YazarSil(int id)
        {
            var x = yazarRepository.TGet(id);
            x.YazarDurum = false;
            yazarRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
    }
}
