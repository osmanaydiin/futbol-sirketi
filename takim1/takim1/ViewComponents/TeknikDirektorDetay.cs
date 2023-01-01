using Microsoft.AspNetCore.Mvc;
using takim1.Repositories;

namespace takim1.ViewComponents
{
    public class TeknikDirektorDetay:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            TeknikDirektorRepository teknikDirektorRepository = new TeknikDirektorRepository();
            var f1 = teknikDirektorRepository.List(parametre => parametre.TeknikDirektorId == id);
            return View(f1);
        }
    }
}
