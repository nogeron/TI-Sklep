using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TI_Sklep.ViewComponents
{
    public class DodawanieFilmowViewModels : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
