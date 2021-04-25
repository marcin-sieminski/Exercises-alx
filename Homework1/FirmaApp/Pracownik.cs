using System;

namespace FirmaApp
{
    public class Pracownik
    {
        public string Imię { get; set; }
        public string Nazwisko { get; set; }
        public string Miasto { get; set; }
        public DateTime DataZatrudnienia { get; set; }

        public Pracownik(string imię, string nazwisko, string miasto)
        {
            Imię = imię;
            Nazwisko = nazwisko;
            Miasto = miasto;
        }
    }
}
