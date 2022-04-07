using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TI_Sklep.Models
{
    public class Film
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Nie podana tytułu")]
        public string Tytul { get; set; }

        public string Rezyser { get; set; }

        [StringLength(1000)]
        public string Opis { get; set; }

        public decimal Cena { get; set; }

        public DateTime? DataDodania { get; set; } // ? - zeby pozwolić na brak Daty produkcji

        [ForeignKey("Kategoria")]
        public int KategoriaId { get; set; }

        public Kategoria Kategoria { get; set; }

        public string Plakat { get; set; }

        public string Dlugosc { get; set; }

    }
}
