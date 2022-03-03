using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TI_Sklep.Models
{
    public class Kategoria
    {
        public int Id { get; set; }

       // [Key]
        public string Nazwa { get; set; }
        public string Opis { get; set; }

        public ICollection<Film> Filmy { get; set; }
    }
}
