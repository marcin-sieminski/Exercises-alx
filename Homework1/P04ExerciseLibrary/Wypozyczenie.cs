using System;

namespace P04ExerciseLibrary
{
    public class Wypozyczenie
    {
        public Czytelnik Czytelnik;
        public DateTime? DataWypozyczenia;
        public DateTime? PrzewidywanaDataZwrotu;
        public DateTime? RzeczywistaDataZwrotu;
        public string Uwagi;
        public Wypozyczenie Przedluzenie;
    }
}
