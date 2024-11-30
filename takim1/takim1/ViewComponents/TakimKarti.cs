using Microsoft.AspNetCore.Mvc;
using takim1.Repositories;

namespace takim1.ViewComponents
{
    public class TakimKarti : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            TakimRepository takimRepository = new TakimRepository();
            var takim = takimRepository.List(parametre => parametre.TakimId == id);
            return View(takim);
        }
    }
}
