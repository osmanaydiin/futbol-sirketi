using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using takim1.Repositories;

namespace takim1.ViewComponents
{
    public class TakimFutbolculari : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {          
            FutbolcuRepository futbolcuRepository = new FutbolcuRepository();
            var futbolcular = futbolcuRepository.List(parametre => parametre.TakimId == id);
            return View(futbolcular);
        }
    }
}
