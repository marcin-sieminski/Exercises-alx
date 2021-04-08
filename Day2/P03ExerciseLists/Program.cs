using System;
using System.Collections.Generic;

namespace P03ExerciseLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz kolejne imiona (koniec = zakończenie wpisywania):");

            var listaImion = new List<string>();

            do
            {
                var bieżącyWpis = Console.ReadLine();
                if (bieżącyWpis == "koniec")
                {
                    break;
                }
                listaImion.Add(bieżącyWpis);
            } while (true);

            Console.WriteLine("Wpisane imiona i ich długości:");
            foreach (var imię in listaImion)
            {
                Console.WriteLine($"{imię} ({imię.Length})");
            }

            Console.ReadKey();
        }
    }
}
