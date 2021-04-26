using System;

namespace Zawodnicy
{
    public class Zawodnik
    {
        public int IdZawodnika;
        public int IdTrenera;
        public string Imie;
        public string Nazwisko;
        public string Kraj;
        public DateTime DataUrodzenia;
        public int Wzrost;
        public int Waga;
        public Trener Trener;
        public Zawody[] UczestnictwoWZawodach;
    }
}
