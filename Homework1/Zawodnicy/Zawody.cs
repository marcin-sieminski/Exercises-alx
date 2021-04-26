using System;

namespace Zawodnicy
{
    public class Zawody
    {
        public int IdZawodow;
        public int IdSkoczni;
        public string Nazwa;
        public Skocznia Skocznia;
        public DateTime Data;
        public Zawodnik[] UczestnicyZawodow;
    }
}
