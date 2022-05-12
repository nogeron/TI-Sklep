using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TI_Sklep.ViewModels
{
    public class UsuwanieElementowKosztkaViewModels
    {
        public int Id { get; set; }

        public int Ilosc { get; set; }

        public decimal WartoscKoszyka { get; set; }

        public int IloscTotal { get; set; }
    }
}
