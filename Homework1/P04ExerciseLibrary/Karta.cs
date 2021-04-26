using System;

namespace P04ExerciseLibrary
{
    public class Karta
    {
        public string Numer;
        public string Tytul;
        public int Wydanie;
        public DateTime DataZakpu;
        public Autor[] Autorzy;
        public Cena Cena;
        public Karta Nastepna;
        public Karta Poprzednia;
        public Sygnatura[] Sygnatury;
    }
}
