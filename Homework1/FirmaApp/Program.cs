using System;

namespace FirmaApp
{
    class Program
    {
        static void Main()
        {
            var firma = new Firma("Sukces");

            firma.Zatrudnij(new Pracownik("Adam", "Abacki", "Warszawa"));
            firma.Zatrudnij(new Pracownik("Anna", "Cabacka", "Piaseczno"));

            var klient1 = new Klient
                {NazwaKlienta = "ABC", AdresKlienta = "Warszawa Puławska 1", TerminPłatnościFaktur = 30};

            var towar1 = new Towar {NazwaTowaru = "Papier biurowy", CenaJednostkowa = 16.90M};
            var towar2 = new Towar {NazwaTowaru = "Długopis", CenaJednostkowa = 10.50M};

            var faktura1 = new Faktura
            {
                NrFaktury = 1, Klient = klient1, PracownikWystawiającyFakturę = firma.Pracownicy[0]
            };
            faktura1.DodajTowarIIlość(towar1, 4);
            faktura1.DodajTowarIIlość(towar2, 10);
            firma.DodajFakturę(faktura1);
            
            var faktura2 = new Faktura
            {
                NrFaktury = 2, Klient = klient1, PracownikWystawiającyFakturę = firma.Pracownicy[1]
            };
            faktura2.DodajTowarIIlość(towar1, 14);
            faktura2.DodajTowarIIlość(towar2, 100);
            firma.DodajFakturę(faktura2);

            Console.WriteLine($"Firma: {firma.NazwaFirmy}. Liczba pracowników: {firma.Pracownicy.Count}");
            Console.WriteLine("\nPracownicy:");
            foreach (var pracownik in firma.Pracownicy)
            {
                Console.WriteLine($"{pracownik.Imię} {pracownik.Nazwisko}, {pracownik.Miasto}, data zatrudnienia: {pracownik.DataZatrudnienia.Date:d}");
            }

            Console.WriteLine($"\nIlość wystawionych faktur: {firma.Faktury.Count}");
            foreach (var faktura in firma.Faktury)
            {
                Console.WriteLine($"\nFaktura nr: {faktura.NrFaktury}");
                Console.WriteLine($"Data wystawienia: {faktura.DataWystawienia.Date:d}");
                Console.WriteLine($"Termin płatności: {faktura.DataPłatności.Date:d}");
                Console.WriteLine($"Klient: {faktura.Klient.NazwaKlienta}");
                Console.WriteLine($"Pracownik wystawiający: {faktura.PracownikWystawiającyFakturę.Imię} {faktura.PracownikWystawiającyFakturę.Nazwisko}");
                Console.WriteLine("Pozycje na fakturze:");
                foreach (var pozycjaFaktury in faktura.TowaryIlość)
                {
                    Console.WriteLine($"{pozycjaFaktury.Key.NazwaTowaru}, ilość: {pozycjaFaktury.Value}, cena jednostkowa: {pozycjaFaktury.Key.CenaJednostkowa}, cena łączna: {pozycjaFaktury.Key.CenaJednostkowa * pozycjaFaktury.Value}");
                }

                Console.WriteLine("-----------------------------------------------------------------------");
            }

            Console.ReadKey();
        }
    }
}
