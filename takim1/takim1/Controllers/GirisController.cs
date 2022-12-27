using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using takim1.Models;

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
            var veriler = c.Kullanicilar.FirstOrDefault(x => x.KullaniciMail == p.KullaniciMail && x.KullaniciSifre == p.KullaniciSifre);
            if(veriler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, p.KullaniciMail)
                };
                var kullaniciIdentity = new ClaimsIdentity(claims,"giriş"); 
                ClaimsPrincipal principal= new ClaimsPrincipal(kullaniciIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index","Takim");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> CikisYap()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }
    }
}
