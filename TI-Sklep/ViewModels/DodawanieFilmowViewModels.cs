using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TI_Sklep.Models;

namespace TI_Sklep.ViewModels
{
    public class DodawanieFilmowViewModels
    {
        public Film Film { get; set; }
        public List<Kategoria> Kategorie { get; set; }
    }   
}
