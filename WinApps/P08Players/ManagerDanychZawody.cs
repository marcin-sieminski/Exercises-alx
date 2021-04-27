using System;
using System.IO;

namespace P08Players
{
    public partial class ManagerDanych
    {
        public Zawody[] Zawody;

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
    }
}
