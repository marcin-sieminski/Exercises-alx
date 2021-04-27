using System;

namespace P08Players
{
    public class Trener
    {
        public int IdTrenera;
        public string Imie;
        public string Nazwisko;
        public DateTime DataUrodzenia;
        public Zawodnik[] Zawodnicy;
        public string ImieNazwisko => Imie + " " + Nazwisko;
        public string Wiersz => $"{IdTrenera};{Imie};{Nazwisko};{DataUrodzenia}";
    }
}
