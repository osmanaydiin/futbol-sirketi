using Microsoft.AspNetCore.Mvc;
using takim1.Repositories;

namespace takim1.ViewComponents
{
    public class TakimlariGor : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            TakimRepository takimRepository = new TakimRepository();
            var takimListesi = takimRepository.TList();
            return View(takimListesi);
        }
    }
}
