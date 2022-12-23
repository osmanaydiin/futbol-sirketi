using Microsoft.AspNetCore.Mvc;
using takim1.Models;
using takim1.Repositories;

namespace takim1.Controllers
{
    public class TakimController : Controller
    {
        TakimRepository takimRepository = new TakimRepository();
        public IActionResult Index()
        {
            return View(takimRepository.TList());
        }
        [HttpGet]
        public IActionResult TakimEkle() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult TakimEkle(Takim t) 
        {
            takimRepository.TAdd(t);
            return RedirectToAction("Index");
        }

    }
}
