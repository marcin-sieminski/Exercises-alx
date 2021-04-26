using System;
using System.Collections.Generic;

namespace FirmaApp
{
    public class Firma
    {
        public string NazwaFirmy { get; set; }
        public List<Pracownik> Pracownicy { get; set; } = new List<Pracownik>();
        public List<Faktura> Faktury { get; set; } = new List<Faktura>();

        public void Zatrudnij(Pracownik pracownik)
        {
            pracownik.DataZatrudnienia = DateTime.Now;
            Pracownicy.Add(pracownik);
        }

        public void DodajFakturę(Faktura faktura)
        {
            Faktury.Add(faktura);
        }
    }
}
