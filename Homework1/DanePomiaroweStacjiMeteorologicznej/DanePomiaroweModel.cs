using System;

namespace DanePomiaroweStacjiMeteorologicznej
{
    public class DanePomiaroweModel
    {
        public DateTime Data { get; set; }
        public TimeSpan Czas { get; set; }
        public float PredkoscDzwieku { get; set; }
        public float TemperaturaDzwiekiem { get; set; }
        public float CisnienieAtmosferyczne { get; set; }
        public float Temperatura { get; set; }
        public float Wilgotnosc { get; set; }
        public int Kompas { get; set; }
        public float PredkoscUv { get; set; }
        public float PredkoscWiatru { get; set; }
        public float Kierunek { get; set; }
        public float Wysokosc { get; set; }
        public float TempWewnatrzPomieszczenia { get; set; }
    }
}
