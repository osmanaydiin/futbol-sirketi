using Microsoft.AspNetCore.Mvc;
using takim1.Repositories;

namespace takim1.ViewComponents
{
    public class TakimTeknikDirektorleri: ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            TeknikDirektorRepository teknikDirektorRepository = new TeknikDirektorRepository();
            var teknikDirektor = teknikDirektorRepository.List(parametre => parametre.TakimId == id);
            return View(teknikDirektor);
        }
    }
}
