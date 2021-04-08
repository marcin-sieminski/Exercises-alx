using System;

namespace P08SelectionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz równanie matematyczne (wyłącznie liczby jednocyfrowe):");

            var równanie = Console.ReadLine();
            double liczba1 = Convert.ToInt32(równanie.Substring(0, 1));
            double liczba2 = Convert.ToInt32(równanie.Substring(2, 1));
            var działanie = char.Parse(równanie.Substring(1, 1));
            double? wynik = null;

            if (działanie == '+')
            {
                wynik = liczba1 + liczba2;
            }
            else if (działanie == '-')
            {
                wynik = liczba1 - liczba2;
            }
            else if (działanie == '*')
            {
                wynik = liczba1 * liczba2;
            }
            else if (działanie == '/')
            {
                wynik = liczba1 / liczba2;
            }
            else
            {
                Console.WriteLine("Zły operator");
            }

            if (wynik != null)
            {
                Console.WriteLine($"Wynik to: {wynik}");
            }
            Console.ReadKey();
        }
    }
}
