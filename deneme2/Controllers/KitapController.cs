using Microsoft.AspNetCore.Mvc;

namespace deneme2.Controllers
{
    public class KitapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
