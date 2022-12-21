using deneme2.Models;
using deneme2.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace deneme2.Controllers
{
    public class YorumController : Controller
    {
        DbCoreKitap dbck = new DbCoreKitap();
        YorumRepository yorumRepository = new YorumRepository();
        public IActionResult Index()
        {
            return View(yorumRepository.TList("Kitap"));
        }
        public IActionResult YorumGet(int id)
        {
            List<SelectListItem> kitaplar = (from y in dbck.Kitaplar.ToList()
                                                select new SelectListItem
                                                {
                                                    Text = y.KitapAdi,
                                                    Value = y.KitapId.ToString()
                                                }).ToList();
            ViewBag.kt1 = kitaplar;

            var x = yorumRepository.TGet(id);
            Yorum k1 = new Yorum()
            {
                YorumId = x.YorumId,
                YorumBaslik = x.YorumBaslik,
                YorumIcerik = x.YorumIcerik,
                KitapId = x.KitapId,
                KullaniciId = x.KullaniciId

            };
            return View(k1);
        }


        public IActionResult YorumSil(int id)
        {
            yorumRepository.TRemove(new Yorum { YorumId = id });
            return RedirectToAction("Index");
        }
    }
}
