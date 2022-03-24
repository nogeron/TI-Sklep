﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TI_Sklep.DAL;

namespace TI_Sklep.ViewComponents
{
    public class FilmyKategoriiViewComponent : ViewComponent
    {
        FilmyContext db;

        public FilmyKategoriiViewComponent(FilmyContext db)
        {
            this.db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync(string nazwaKategorii)
        {
        var kategoria = db.Kategorie.Include("Filmy").Where(k => k.Nazwa == nazwaKategorii).Single();
        var filmy = kategoria.Filmy.ToList();

            return await Task.FromResult((IViewComponentResult) View("_FilmyKategorii", filmy));
        }
    }
}
