using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace P08Players
{
    public partial class ManagerDanych
    {
        public Zawodnik[] Zawodnicy;

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

        public void UsunZawodnika(int id)
        {
            List<Zawodnik> zawodnicy = Zawodnicy.ToList();
            for (var index = 0; index < zawodnicy.Count; index++)
            {
                if (zawodnicy[index].IdZawodnika == id)
                {
                    zawodnicy.RemoveAt(index);
                    Zawodnicy = zawodnicy.ToArray();
                    break;
                }
            }
        }

        public void EksportujZawodników()
        {
            string[] wiersze = new string[Zawodnicy.Length];
            for (int i = 0; i < Zawodnicy.Length; i++)
            {
                wiersze[i] = Zawodnicy[i].Wiersz;
            }
            File.WriteAllLines(sciezka + "\\" + "zawodnicy.txt", wiersze);
        }

        public void DodajZawodnika(Zawodnik zawodnik)
        {
            List<Zawodnik> zawodnicy = Zawodnicy.ToList();
            zawodnik.IdZawodnika = PodajMaksymalneId() + 1;
            zawodnicy.Add(zawodnik);
            Zawodnicy = zawodnicy.ToArray();
        }

        private int PodajMaksymalneId()
        {
            int maksId = 0;
            foreach (var zawodnik in Zawodnicy)
            {
                if (zawodnik.IdZawodnika > maksId)
                {
                    maksId = zawodnik.IdZawodnika;
                }
            }

            return maksId;
        }

        public void EdytujZawodnika(Zawodnik z)
        {
            for (var index = 0; index < Zawodnicy.Length; index++)
            {
                if (Zawodnicy[index].IdZawodnika == z.IdZawodnika)
                {
                    Zawodnicy[index].Imie = z.Imie;
                    Zawodnicy[index].Nazwisko = z.Nazwisko;
                    Zawodnicy[index].Kraj = z.Kraj;
                    Zawodnicy[index].DataUrodzenia = z.DataUrodzenia;
                    Zawodnicy[index].Wzrost = z.Wzrost;
                    Zawodnicy[index].Waga = z.Waga;
                    break;
                }
            }
        }
    }
}
