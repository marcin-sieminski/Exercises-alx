using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;

namespace DanePomiaroweStacjiMeteorologicznej
{
    public class PogodaManager
    {
        public List<DanePomiaroweModel> DanePomiarowe { get; set; } = new List<DanePomiaroweModel>();
        public List<string> BledneDane { get; set; } = new List<string>();
        public int DataMiesiac { get; set; }
        public int DataRok { get; set; }
        public string Adres { get; set; } = "http://www.pimr.poznan.pl/bup/write/";
        public string NazwaPliku
        {
            get
            {
                string miesiac = DataMiesiac > 9 ? $"{DataMiesiac}" : $"0{DataMiesiac}";
                return $"data{miesiac}-{DataRok}.csv";
            } 
        }

        public PogodaManager(int miesiac, int rok)
        {
            DataMiesiac = miesiac;
            DataRok = rok;
        }

        public void Wczytaj()
        {
            string[] wiersze;
            try
            {
                wiersze = new WebClient()
                    .DownloadString(Adres + NazwaPliku)
                    .Split(new string[]{"\n"}, StringSplitOptions.RemoveEmptyEntries);
            }
            catch (Exception)
            {
                throw new Exception("Błąd wczytywania danych.");
            }

            for (int i = 2; i < wiersze.Length; i++)
            {
                string[] komorki = wiersze[i].Split(';');
                var nfi = new NumberFormatInfo{NumberDecimalSeparator = "."};

                DanePomiaroweModel danePomiarowe = new DanePomiaroweModel();
                try
                {
                    danePomiarowe.Data = Convert.ToDateTime(komorki[0]);
                    danePomiarowe.Czas = Convert.ToDateTime(komorki[1]).TimeOfDay;
                    danePomiarowe.PredkoscDzwieku = Convert.ToSingle(komorki[2], nfi);
                    danePomiarowe.TemperaturaDzwiekiem = Convert.ToSingle(komorki[3], nfi);
                    danePomiarowe.CisnienieAtmosferyczne = Convert.ToSingle(komorki[4], nfi);
                    danePomiarowe.Temperatura = Convert.ToSingle(komorki[5], nfi);
                    danePomiarowe.Wilgotnosc = Convert.ToSingle(komorki[6], nfi);
                    danePomiarowe.Kompas = Convert.ToInt32(komorki[7]);
                    danePomiarowe.PredkoscUv = Convert.ToSingle(komorki[8], nfi);
                    danePomiarowe.PredkoscWiatru = Convert.ToSingle(komorki[9], nfi);
                    danePomiarowe.Kierunek = Convert.ToSingle(komorki[10], nfi);
                    danePomiarowe.Wysokosc = Convert.ToSingle(komorki[11], nfi);
                    danePomiarowe.TempWewnatrzPomieszczenia = Convert.ToSingle(komorki[12], nfi);
                    DanePomiarowe.Add(danePomiarowe);
                }
                catch (Exception)
                {
                    BledneDane.Add(wiersze[i]);
                }
            }
        }

        public float SredniaTemperatura()
        {
            return DanePomiarowe.Average(x => x.Temperatura);
        }
    }
}
