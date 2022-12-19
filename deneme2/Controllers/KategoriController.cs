using deneme2.Models;
using deneme2.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace deneme2.Controllers
{
    public class KategoriController : Controller
    {
        KategoriRepository kategoriRepository = new KategoriRepository();
        public IActionResult Index()
        {
            return View(kategoriRepository.TList());
        }
        [HttpGet]
        public IActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult KategoriEkle(Kategori ktg)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            kategoriRepository.TAdd(ktg);
            return RedirectToAction("Index");
        }
    }
}
