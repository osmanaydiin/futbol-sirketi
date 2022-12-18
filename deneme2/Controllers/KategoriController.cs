using deneme2.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace deneme2.Controllers
{
    public class KategoriController : Controller
    {
        public IActionResult Index()
        {
            KategoriRepository kategoriRepository = new KategoriRepository();
            return View(kategoriRepository.TList());
        }
    }
}
