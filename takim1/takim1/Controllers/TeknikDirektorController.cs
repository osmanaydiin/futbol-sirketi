using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Drawing;
using takim1.Models;
using takim1.Repositories;
using X.PagedList;

namespace takim1.Controllers
{
    public class TeknikDirektorController : Controller
    {
        Context c = new Context();
        TeknikDirektorRepository teknikDirektorRepository = new TeknikDirektorRepository();
        public IActionResult Index(int page = 1)
        {
            return View(teknikDirektorRepository.TList("Takim").ToPagedList(page, 4));
        }
        [HttpGet]
        public IActionResult TeknikDirektorEkle()
        {
            List<SelectListItem> takimlar = (from x in c.Takimlar.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.TakimAdi,
                                                 Value = x.TakimId.ToString()
                                             }).ToList();
            ViewBag.kt1 = takimlar;
            return View();
        }
        [HttpPost]
        public IActionResult TeknikDirektorEkle(TeknikDirektor f)
        {
            teknikDirektorRepository.TAdd(f);
            return RedirectToAction("Index");
        }
        public IActionResult TeknikDirektorSil(int id)
        {
            teknikDirektorRepository.TRemove(new TeknikDirektor { TeknikDirektorId = id });
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult TeknikDirektorGet(int id)
        {
            var x = teknikDirektorRepository.TGet(id);
            List<SelectListItem> takimlar = (from y in c.Takimlar.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = y.TakimAdi,
                                                 Value = y.TakimId.ToString()
                                             }).ToList();
            ViewBag.kt1 = takimlar;
            TeknikDirektor f = new TeknikDirektor()
            {
                TakimId = x.TakimId,
                TeknikDirektorId = x.TeknikDirektorId,
                TeknikDirektorAdi = x.TeknikDirektorAdi,
                TeknikDirektorSoyadi = x.TeknikDirektorSoyadi,
                TeknikDirektorYas = x.TeknikDirektorYas,
                TeknikDirektorMaas = x.TeknikDirektorMaas,
                TeknikDirektorGecmis = x.TeknikDirektorGecmis,
                TeknikDirektorResimUrl = x.TeknikDirektorResimUrl,             
            };
            return View(f);
        }
        [HttpPost]
        public IActionResult TeknikDirektorGuncelle(TeknikDirektor k)
        {
            var x = teknikDirektorRepository.TGet(k.TeknikDirektorId);
            x.TeknikDirektorAdi = k.TeknikDirektorAdi;
            x.TeknikDirektorSoyadi = k.TeknikDirektorSoyadi;
            x.TeknikDirektorYas = k.TeknikDirektorYas;
            x.TeknikDirektorMaas = k.TeknikDirektorMaas;
            x.TeknikDirektorGecmis = k.TeknikDirektorGecmis;
            x.TeknikDirektorResimUrl = k.TeknikDirektorResimUrl;
            x.TakimId = k.TakimId;
            teknikDirektorRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
    }
}
