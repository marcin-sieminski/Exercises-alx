using System;

namespace P04ExerciseStrings
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj dwie liczby:");
            var liczba1 = Convert.ToInt32(Console.ReadLine());
            var liczba2 = Convert.ToInt32(Console.ReadLine());

            var suma = liczba1 + liczba2;
            var iloscCyfr = suma.ToString().Length;

            Console.WriteLine($"Wynik to: {suma:F3}");
            Console.WriteLine($"Ilość cyfr wyniku: {iloscCyfr}");

            string napis2 = string.Format("wynik to {0:E}, a długość napisu to {1}", suma, iloscCyfr);
            Console.WriteLine(napis2);

            Console.ReadKey();
        }
    }
}
