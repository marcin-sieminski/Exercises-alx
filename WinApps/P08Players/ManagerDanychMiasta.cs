using System;
using System.IO;

namespace P08Players
{
    public partial class ManagerDanych
    {
        public Miasto[] Miasta;


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
