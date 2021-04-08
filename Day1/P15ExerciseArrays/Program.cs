using System;

namespace P15ExerciseArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj imiona:");
            string[] tabImion = new string[50];
            int i = 0;

            while (true)
            {
                var bieżącyWpis = Console.ReadLine();
                if (bieżącyWpis.ToLower() == "koniec")
                {
                    break;
                }

                tabImion[i] = bieżącyWpis;
                i++;
            }

            for (int j = 0; j < i; j++)
            {
                Console.WriteLine("{0} ({1})", tabImion[j], tabImion[j].Length);
            }

            Console.ReadKey();
        }
    }
}
