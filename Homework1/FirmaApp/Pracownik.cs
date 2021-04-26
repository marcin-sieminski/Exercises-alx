using System;

namespace FirmaApp
{
    public class Pracownik
    {
        public string Imię { get; set; }
        public string Nazwisko { get; set; }
        public string Miasto { get; set; }
        public DateTime DataZatrudnienia { get; set; }
        public decimal Wynagrodzenie { get; set; }
        public string ImięNazwisko
        {
            get => Imię + " " + Nazwisko;
            set
            {
                Imię = value.Split(' ')[0];
                Nazwisko = value.Split(' ')[1];
            }
        }

        public Pracownik(string imię, string nazwisko, string miasto, decimal wynagrodzenie)
        {
            Imię = imię;
            Nazwisko = nazwisko;
            Miasto = miasto;
            Wynagrodzenie = wynagrodzenie;
        }
    }
}
