using takim1.Models;
using takim1.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using takim1.Models;
using X.PagedList;

namespace takim1.Controllers
{
	public class KullaniciController : Controller
	{
		Context dbck = new Context();
		KullaniciRepository kullaniciRepository = new KullaniciRepository();
		public IActionResult Index(int page = 1)
		{
			return View(kullaniciRepository.TList().ToPagedList(page, 4));
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
				KullaniciRol = x.KullaniciRol,
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
			x.KullaniciRol = k.KullaniciRol;
			kullaniciRepository.TUpdate(x);
			return RedirectToAction("Index");
		}
		public IActionResult KullaniciSil(int id)
		{
            kullaniciRepository.TRemove(new Kullanici { KullaniciId = id });
            return RedirectToAction("Index");
		}
	}
}