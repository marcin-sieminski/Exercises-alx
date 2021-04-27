namespace P08Players
{
    public partial class ManagerDanych
    {
        private const string sciezka = "c:\\tools\\";

        public void ImportujWszystko()
        {
            ImportujZawodnikow();
            ImportujTrenerow();
            ImportujZawody();
            ImportujSkocznie();
            ImportujMiasta();
            PowiazDane();
        }

        private void PowiazDane()
        {
            foreach (var item in Zawodnicy)
                item.Trener = PodajTrenera(item.IdTrenera);

            foreach (var item in Zawody)
                item.Skocznia = PodajSkocznie(item.IdSkoczni);

            foreach (var item in Skocznie)
                item.Miasto = PodajMiasto(item.IdMiasta);
        }
    }
}
