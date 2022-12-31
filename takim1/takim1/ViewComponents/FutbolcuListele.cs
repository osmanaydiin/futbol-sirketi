using Microsoft.AspNetCore.Mvc;
using takim1.Repositories;

namespace takim1.ViewComponents
{
    public class FutbolcuListele : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            FutbolcuRepository futbolcuRepository = new FutbolcuRepository();
            var futbolcular = futbolcuRepository.TList();
            return View(futbolcular);
        }
    }
}
