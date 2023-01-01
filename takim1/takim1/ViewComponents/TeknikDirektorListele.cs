using Microsoft.AspNetCore.Mvc;
using takim1.Repositories;

namespace takim1.ViewComponents
{
    public class TeknikDirektorListele:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            TeknikDirektorRepository teknikDirektorRepository = new TeknikDirektorRepository();
            var futbolcular = teknikDirektorRepository.TList();
            return View(futbolcular);
        }
    }
}
