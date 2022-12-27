using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace takim1.Controllers
{
    public class AnaSayfaController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
    }
}
