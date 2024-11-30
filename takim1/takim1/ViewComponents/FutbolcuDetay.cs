using Microsoft.AspNetCore.Mvc;
using takim1.Repositories;

namespace takim1.ViewComponents
{
    public class FutbolcuDetay:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            FutbolcuRepository futbolcuRepository = new FutbolcuRepository();
            var f1= futbolcuRepository.List(parametre => parametre.FutbolcuId == id);
            return View(f1);
        }
    }
}
