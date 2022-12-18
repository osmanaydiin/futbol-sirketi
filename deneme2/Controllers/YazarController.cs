using deneme2.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace deneme2.Controllers
{
    public class YazarController : Controller
    {
        public IActionResult Index()
        {
            YazarRepository yazarRepository = new YazarRepository();
            return View(yazarRepository.TList());
        }
    }
}
