using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using takim1.Models;
using takim1.Repositories;

namespace takim1.Controllers
{

    public class GirisController : Controller
    {
        Context c = new Context();
        //auhorizationdan bağımsız hale geldi
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Index(Kullanici p)
        {
            var veriler = c.Kullanicilar.FirstOrDefault(gelenVeri => gelenVeri.KullaniciMail == p.KullaniciMail && gelenVeri.KullaniciSifre == p.KullaniciSifre);
            if(veriler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, p.KullaniciMail)
                };
                var kullaniciIdentity = new ClaimsIdentity(claims,"Giris"); 
                ClaimsPrincipal principal= new ClaimsPrincipal(kullaniciIdentity);
                await HttpContext.SignInAsync(principal);
                if(veriler.KullaniciRol == "a")
                {
                    return RedirectToAction("Index", "Takim");
                }
                else
                {
                    return RedirectToAction("Index", "AnaSayfa");
                }
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> CikisYap()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "AnaSayfa");
        }
        [AllowAnonymous]
		[HttpGet]
		public IActionResult GiristenKullaniciEkle()
        {
            return View();
		}
        [AllowAnonymous]
		[HttpPost]
		public IActionResult GiristenKullaniciEkle(Kullanici ktg)
        {
            KullaniciRepository kullaniciRepository = new KullaniciRepository();
            ktg.KullaniciRol = "k";
			kullaniciRepository.TAdd(ktg);
			return RedirectToAction("Index","Giris");
		}

	}
}
