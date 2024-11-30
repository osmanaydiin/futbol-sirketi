using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using takim1.Models;
using takim1.Repositories;
using X.PagedList;

namespace takim1.Controllers
{
    public class FutbolcuController : Controller
    {
        Context c = new Context();
        FutbolcuRepository futbolcuRepository = new FutbolcuRepository();
        
        public IActionResult Index(int page=1)
        {
            return View(futbolcuRepository.TList("Takim").ToPagedList(page,4));
        }
        [HttpGet]
        public IActionResult FutbolcuEkle() 
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
        public IActionResult FutbolcuEkle(Futbolcu f)
        {
           
            futbolcuRepository.TAdd(f);
            return RedirectToAction("Index");
        }
        public IActionResult FutbolcuSil(int id)
        {
            futbolcuRepository.TRemove( new Futbolcu { FutbolcuId = id});
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult FutbolcuGet(int id)
        {
            var x = futbolcuRepository.TGet(id);
            List<SelectListItem> takimlar = (from y in c.Takimlar.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = y.TakimAdi,
                                                 Value = y.TakimId.ToString()
                                             }).ToList();
            ViewBag.kt1 = takimlar;
            Futbolcu f = new Futbolcu()
            {
                FutbolcuId = x.FutbolcuId,
                TakimId = x.TakimId,
                FutbolcuAdi = x.FutbolcuAdi,
                FutbolcuSoyadi = x.FutbolcuSoyadi,
                FutbolcuYas = x.FutbolcuYas,
                FutbolcuMaas = x.FutbolcuMaas,
                FutbolcuDeger = x.FutbolcuDeger,
                FutbolcuGecmis = x.FutbolcuGecmis,
                FutbolcuMevki = x.FutbolcuMevki,
                FutbolcuNumara = x.FutbolcuNumara,
                FutbolcuResimUrl = x.FutbolcuResimUrl,

            };
            return View(f);
        }
        [HttpPost]
        public IActionResult FutbolcuGuncelle(Futbolcu k)
        {
            var x = futbolcuRepository.TGet(k.FutbolcuId);
            x.FutbolcuAdi = k.FutbolcuAdi;
            x.FutbolcuSoyadi = k.FutbolcuSoyadi;
            x.FutbolcuYas = k.FutbolcuYas;
            x.FutbolcuMaas = k.FutbolcuMaas;
            x.FutbolcuDeger = k.FutbolcuDeger;
            x.FutbolcuMevki = k.FutbolcuMevki;
            x.FutbolcuNumara = k.FutbolcuNumara;
            x.FutbolcuGecmis = k.FutbolcuGecmis;
            x.FutbolcuResimUrl = k.FutbolcuResimUrl;
            x.TakimId = k.TakimId;
            futbolcuRepository.TUpdate(x);
            return RedirectToAction("Index");

        }
    }
}
