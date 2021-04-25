using System;
using System.Collections.Generic;

namespace FirmaApp
{
    public class Faktura
    {
        public int NrFaktury { get; set; }
        public DateTime DataWystawienia { get; set; } = DateTime.Now;
        public DateTime DataPłatności => DataWystawienia.AddDays(Klient.TerminPłatnościFaktur);
        public Klient Klient { get; set; }
        public Dictionary<Towar, int> TowaryIlość { get; set; } = new Dictionary<Towar, int>();
        public Pracownik PracownikWystawiającyFakturę { get; set; }

        public void DodajTowarIIlość(Towar towar, int ilość)
        {
            TowaryIlość.Add(towar, ilość);
        }
    }
}