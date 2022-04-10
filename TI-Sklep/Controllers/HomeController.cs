using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TI_Sklep.DAL;
using TI_Sklep.ViewModels;

namespace TI_Sklep.Controllers
{
    public class HomeController : Controller
    {
       FilmyContext db;

        public HomeController(FilmyContext db)
        {
            this.db=db;
        }
        

        public IActionResult Index()
        {
            KategoriaViewModels vm = new KategoriaViewModels();
            vm.FilmyTop3Najdluszsze = db.Filmy.OrderByDescending(f => f.Dlugosc).Take(3);
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult StronyStatyczne(string nazwa)
        {
            return View(nazwa);
        }

       // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

    }
}
