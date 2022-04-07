using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TI_Sklep.Models;

namespace TI_Sklep.ViewModels
{
    public class KategoriaViewModels
    {
        public Kategoria Kategoria { get; set; }

        public IEnumerable<Film> FilmyKategorii { get; set;}

        public IEnumerable<Film> FilmyTop3Najnowsze { get; set; }

        public IEnumerable<Film> FilmyTop3Najdluszsze { get; set; }
    }
}
