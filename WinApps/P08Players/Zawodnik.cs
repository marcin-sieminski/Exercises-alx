using System;

namespace P08Players
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

        public string ImieNazwiskoKraj => Imie + " " + Nazwisko + " " + Kraj;
        public string Wiersz => $"{IdZawodnika};{IdTrenera};{Imie};{Nazwisko};{Kraj};{DataUrodzenia};{Wzrost};{Waga}";
    }
}
