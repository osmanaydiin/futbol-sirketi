using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace takim1.Controllers
{
    public class AnaSayfaController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TakimBilgi (int id)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}
