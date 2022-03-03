using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TI_Sklep.Models
{
    public class Film
    {
        public int Id { get; set; }

        public string Tytul { get; set; }

        public string Rezyser { get; set; }

        public string Opis { get; set; }

        public decimal Cena { get; set; }

        public DateTime DataProdukcji { get; set; }
    }
}
