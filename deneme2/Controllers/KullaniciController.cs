using deneme2.Models;
using deneme2.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace deneme2.Controllers
{
    public class KullaniciController : Controller
    {
        DbCoreKitap dbck = new DbCoreKitap();
        KullaniciRepository kullaniciRepository = new KullaniciRepository();
        public IActionResult Index()
        {
            return View(kullaniciRepository.TList());
        }

        [HttpGet]
        public IActionResult KullaniciEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult KullaniciEkle(Kullanici ktg)
        {

            kullaniciRepository.TAdd(ktg);
            return RedirectToAction("Index");
        }
        public IActionResult KullaniciGet(int id)
        {
            var x = kullaniciRepository.TGet(id);
            Kullanici ktg = new Kullanici()
            {
                KullaniciId = x.KullaniciId,
                KullaniciAdi = x.KullaniciAdi,
                KullaniciSoyadi = x.KullaniciSoyadi,
                KullaniciMail = x.KullaniciMail,
                KullaniciSifre = x.KullaniciSifre,

            };
            return View(ktg);
        }
        [HttpPost]
        public IActionResult KullaniciGuncelle(Kullanici k)
        {
            var x = kullaniciRepository.TGet(k.KullaniciId);
            x.KullaniciAdi = k.KullaniciAdi;
            x.KullaniciSoyadi = k.KullaniciSoyadi;
            x.KullaniciMail = k.KullaniciMail;
            x.KullaniciSifre = k.KullaniciSifre;
            x.KullaniciDurum = true;
            kullaniciRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
        public IActionResult KullaniciSil(int id)
        {
            var x = kullaniciRepository.TGet(id);
            x.KullaniciDurum = false;
            kullaniciRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
    }
}
