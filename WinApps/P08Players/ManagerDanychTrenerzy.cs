using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace P08Players
{
    public partial class ManagerDanych
    {
        public Trener[] Trenerzy;

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

        public void DodajTrenera(Trener trener)
        {
            List<Trener> trenerzy = Trenerzy.ToList();
            trener.IdTrenera = PodajMaksymalneIdTrenera() + 1;
            trenerzy.Add(trener);
            Trenerzy = trenerzy.ToArray();
        }

        private int PodajMaksymalneIdTrenera()
        {
            int maksId = 0;
            foreach (var trener in Trenerzy)
            {
                if (trener.IdTrenera > maksId)
                {
                    maksId = trener.IdTrenera;
                }
            }

            return maksId;
        }

        public void EksportujTrenerow()
        {
            string[] wiersze = new string[Trenerzy.Length];
            for (int i = 0; i < Trenerzy.Length; i++)
            {
                wiersze[i] = Trenerzy[i].Wiersz;
            }
            File.WriteAllLines(sciezka + "\\" + "trenerzy.txt", wiersze);
        }

        public void EdytujTrenera(Trener trener)
        {
            for (var index = 0; index < Trenerzy.Length; index++)
            {
                if (Trenerzy[index].IdTrenera == trener.IdTrenera)
                {
                    Trenerzy[index].Imie = trener.Imie;
                    Trenerzy[index].Nazwisko = trener.Nazwisko;
                    Trenerzy[index].DataUrodzenia = trener.DataUrodzenia;
                    break;
                }
            }
        }

        public void UsunTrenera(int id)
        {
            List<Trener> trenerzy = Trenerzy.ToList();
            for (var index = 0; index < trenerzy.Count; index++)
            {
                if (trenerzy[index].IdTrenera == id)
                {
                    trenerzy.RemoveAt(index);
                    Trenerzy = trenerzy.ToArray();
                    break;
                }
            }
        }


    }
}
