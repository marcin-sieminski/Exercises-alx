using System;
using System.IO;

namespace Zawodnicy
{
    public class ManagerDanych
    {
        private const string sciezka = "c:\\tools\\";
        private Trener[] Trenerzy;
        private Zawodnik[] Zawodnicy;
        private Zawody[] Zawody;
        private Skocznia[] Skocznie;
        private Miasto[] Miasta;

        public void ImportujWszystko()
        {
            ImportujTrenerow();
            ImportujZawodnikow();
            ImportujZawody();
            ImportujSkocznie();
            ImportujMiasta();
            PowiazDane();
        }


        public void PowiazDane()
        {
            foreach (var item in Zawodnicy)
                item.Trener = PodajTrenera(item.IdTrenera);

            foreach (var item in Zawody)
                item.Skocznia = PodajSkocznie(item.IdSkoczni);

            foreach (var item in Skocznie)
                item.Miasto = PodajMiasto(item.IdMiasta);
        }

        public Zawodnik PodajZawodnika(int id)
        {
            foreach (var zawodnik in Zawodnicy)
            {
                if (zawodnik.IdZawodnika == id)
                {
                    return zawodnik;
                }
            }

            return null;
        }

        public Trener PodajTrenera(int id)
        {
            foreach (var trener in Trenerzy)
            {
                if (trener.IdTrenera == id)
                {
                    return trener;
                }
            }

            return null;
        }

        public Zawody PodajZawody(int id)
        {
            foreach (var zawody in Zawody)
            {
                if (zawody.IdZawodow == id)
                {
                    return zawody;
                }
            }

            return null;
        }

        public Miasto PodajMiasto(int id)
        {
            foreach (var miasto in Miasta)
            {
                if (miasto.IdMiasta == id)
                {
                    return miasto;
                }
            }

            return null;
        }

        public Skocznia PodajSkocznie(int id)
        {
            foreach (var skocznia in Skocznie)
            {
                if (skocznia.IdSkoczni == id)
                {
                    return skocznia;
                }
            }

            return null;
        }

        public void ImportujTrenerow()
        {
            string[] wiersze = File.ReadAllLines(sciezka + "trenerzy.txt");
            Trenerzy = new Trener[wiersze.Length];
            for (int i = 0; i < wiersze.Length; i++)
            {
                string[] komorki = wiersze[i].Split(';');
                Trenerzy[i] = new Trener()
                {
                    IdTrenera = Convert.ToInt32(komorki[0]),
                    Imie = komorki[1],
                    Nazwisko = komorki[2],
                    DataUrodzenia = Convert.ToDateTime(komorki[3])
                };
            }
        }

        public void ImportujZawodnikow()
        {
            string[] wiersze = File.ReadAllLines(sciezka + "zawodnicy.txt");
            Zawodnicy = new Zawodnik[wiersze.Length];
            for (int i = 0; i < wiersze.Length; i++)
            {
                string[] komorki = wiersze[i].Split(';');
                Zawodnicy[i] = new Zawodnik()
                {
                    IdZawodnika = Convert.ToInt32(komorki[0]),
                    IdTrenera = Convert.ToInt32(komorki[1]),
                    Imie = komorki[2],
                    Nazwisko = komorki[3],
                    Kraj = komorki[4],
                    DataUrodzenia = Convert.ToDateTime(komorki[5]),
                    Wzrost = Convert.ToInt32(komorki[6]),
                    Waga = Convert.ToInt32(komorki[7])
                };
            }
        }

        public void ImportujZawody()
        {
            string[] wiersze = File.ReadAllLines(sciezka + "zawody.txt");
            Zawody = new Zawody[wiersze.Length];
            for (int i = 0; i < wiersze.Length; i++)
            {
                string[] komorki = wiersze[i].Split(';');
                Zawody[i] = new Zawody()
                {
                    IdZawodow = Convert.ToInt32(komorki[0]),
                    Nazwa = komorki[1],
                    IdSkoczni = Convert.ToInt32(komorki[2]),
                    Data = Convert.ToDateTime(komorki[3])
                };
            }
        }

        public void ImportujSkocznie()
        {
            string[] wiersze = File.ReadAllLines(sciezka + "skocznie.txt");
            Skocznie = new Skocznia[wiersze.Length];
            for (int i = 0; i < wiersze.Length; i++)
            {
                string[] komorki = wiersze[i].Split(';');
                Skocznie[i] = new Skocznia()
                {
                    IdSkoczni = Convert.ToInt32(komorki[0]),
                    IdMiasta = Convert.ToInt32(komorki[1]),
                    NazwaSkoczni = komorki[2],
                    K = Convert.ToInt32(komorki[3]),
                    Sedz = Convert.ToInt32(komorki[4]),
                    KrajSkoczni = komorki[5]
                };
            }
        }

        public void ImportujMiasta()
        {
            string[] wiersze = File.ReadAllLines(sciezka + "miasta.txt");
            Miasta = new Miasto[wiersze.Length];
            for (int i = 0; i < wiersze.Length; i++)
            {
                string[] komorki = wiersze[i].Split(';');
                Miasta[i] = new Miasto()
                {
                    IdMiasta = Convert.ToInt32(komorki[0]),
                    NazwaMiasta = komorki[1],
                };
            }
        }

    }
}
