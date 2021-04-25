using System;

namespace DanePomiaroweStacjiMeteorologicznej
{
    class Program
    {
        static void Main()
        {
            bool czyKontynuowac = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Manager danych stacji pogodowej\n");
                Console.WriteLine("\nPodaj rok: ");
                var rok = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nPodaj miesiąc: ");
                var miesiac = Convert.ToInt32(Console.ReadLine());

                var pogodaManager = new PogodaManager(miesiac,rok);

                try
                {
                    pogodaManager.Wczytaj();
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Naciśnij dowolny klawisz aby kontynuować.");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine($"\nŚrednia temperatura w miesiącu {pogodaManager.DataMiesiac}/{pogodaManager.DataRok}: {pogodaManager.SredniaTemperatura():F2} st.");

                Console.WriteLine("\nChcesz kontynuować? (t/n)");
                czyKontynuowac = Console.ReadKey().KeyChar == 't';
            } while (czyKontynuowac);
        }
    }
}
