using System.Collections.Generic;

namespace P04ExerciseLibrary
{
    public class Sygnatura
    {
        public bool Aktywna;
        public string Uwagi;
        public int Numer;
        public List<Wypozyczenie> Wypozyczenia;

        public Sygnatura()
        {
            Aktywna = true;
        }
    }
}
