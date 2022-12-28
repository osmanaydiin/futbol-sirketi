using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace takim1.Controllers
{
    //kımın girdiğini seçecegimiz sayfa
    public class GiristenOnceController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
    }
}
