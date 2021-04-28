using System;

namespace P04PlayersManager.Domain
{
    class Player
    {
        public int Id;
        public int? Id_trenera;
        public string Imie;
        public string Nazwisko;
        public string Kraj;
        public DateTime DataUr;
        public int Wzrost;
        public int Waga;
        public string ImieNazwiskoKraj => Imie + " " + Nazwisko + " " + Kraj;
    }
}
