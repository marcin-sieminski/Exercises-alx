using System;
using System.IO;

namespace P08Players
{
    public partial class ManagerDanych
    {
        public Skocznia[] Skocznie;

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

    }
}
