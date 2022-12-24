using Microsoft.AspNetCore.Mvc;
using takim1.Models;
using takim1.Repositories;

namespace takim1.Controllers
{
    public class TakimController : Controller
    {
        TakimRepository takimRepository = new TakimRepository();
        public IActionResult Index()
        {
            return View(takimRepository.TList());
        }
        [HttpGet]
        public IActionResult TakimEkle() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult TakimEkle(Takim t) 
        {
            takimRepository.TAdd(t);
            return RedirectToAction("Index");
        }
        public IActionResult TakimGet(int id)
        {
            var x = takimRepository.TGet(id);
            Takim ktg = new Takim()
            {
                TakimId = x.TakimId,
                TakimAdi = x.TakimAdi,
                TakimSampiyonluk = x.TakimSampiyonluk,
                TakimDeger = x.TakimDeger,
                TakimKurulus = x.TakimKurulus,
                TakimResimUrl = x.TakimResimUrl,
            };
            return View(ktg);
        }
        [HttpPost]
        public IActionResult TakimGuncelle(Takim k)
        {
            var x = takimRepository.TGet(k.TakimId);
            x.TakimAdi = k.TakimAdi;
            x.TakimSampiyonluk = k.TakimSampiyonluk;
            x.TakimDeger = k.TakimDeger;
            x.TakimKurulus = k.TakimKurulus;
            x.TakimResimUrl = k.TakimResimUrl;
            x.TakimDurum = true;
            takimRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
        public IActionResult TakimSil(int id)
        {
            var x = takimRepository.TGet(id);
            x.TakimDurum = false;
            takimRepository.TUpdate(x);
            return RedirectToAction("Index");
        }


    }
}
