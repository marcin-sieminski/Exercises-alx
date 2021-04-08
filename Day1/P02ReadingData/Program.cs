using System;

namespace P02ReadingData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dzień dobry");
            string zmiennaTekstowa = Console.ReadLine();
            zmiennaTekstowa = zmiennaTekstowa + " Marcin";
            var liczba = Console.ReadLine();
            int liczba2 = Convert.ToInt32(liczba);
            var liczba3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(zmiennaTekstowa);
            Console.ReadKey();
        }
    }
}
