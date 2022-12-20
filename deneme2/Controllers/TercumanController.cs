using deneme2.Models;
using deneme2.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace deneme2.Controllers
{
    public class TercumanController : Controller
    {
        TercumanRepository tercumanRepository = new TercumanRepository();
        public IActionResult Index()
        {
            return View(tercumanRepository.TList());
        }
        [HttpGet]
        public IActionResult TercumanEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TercumanEkle(Tercuman y)
        {

            tercumanRepository.TAdd(y);
            return RedirectToAction("Index");
        }
        public IActionResult TercumanGet(int id)
        {
            var x = tercumanRepository.TGet(id);
            Tercuman y1 = new Tercuman()
            {
                TrcId = x.TrcId,
                TrcAdi = x.TrcAdi,
                TrcSoyadi = x.TrcSoyadi,
            };
            return View(y1);
        }
        [HttpPost]
        public IActionResult TercumanGuncelle(Tercuman y)
        {
            var x = tercumanRepository.TGet(y.TrcId);
            x.TrcAdi = y.TrcAdi;
            x.TrcSoyadi = y.TrcSoyadi;
            x.TrcDurum = true;
            tercumanRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
        public IActionResult TercumanSil(int id)
        {
            var x = tercumanRepository.TGet(id);
            x.TrcDurum = false;
            tercumanRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
    }
}
