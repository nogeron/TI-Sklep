﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TI_Sklep.DAL;

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
           var kategorie = db.Kategorie.ToList();
            return View(kategorie);
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
