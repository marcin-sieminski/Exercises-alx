using System;

namespace P11ExerciseIterations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz zdanie:");
            var zdanie = Console.ReadLine().ToLower();

            Console.WriteLine("Podaj szukany znak lub wyraz:");
            var szukanyElement = Console.ReadLine().ToLower();

            var długośćElementu = szukanyElement.Length;
            var ilośćWystąpień = 0;
            var pozycja = 0;

            while (pozycja < zdanie.Length -1 - długośćElementu)
            {
                if (szukanyElement == zdanie.Substring(0 + pozycja, długośćElementu))
                {
                    ilośćWystąpień++;
                }
                pozycja++;
            }

            Console.WriteLine($"Ilość wystąpień {ilośćWystąpień} razy");
            Console.ReadKey();
        }
    }
}
