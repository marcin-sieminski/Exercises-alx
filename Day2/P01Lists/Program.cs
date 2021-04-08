using System;
using System.Collections.Generic;

namespace P01Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[3];

            //wielkość tablicy:
            var wielkTab = tablica.Length;

            List<int> lista = new List<int>();

            //wielkość listy
            var wielkList = lista.Count;

            lista.Add(4);
            lista.Add(2);
            lista.Add(5);

            lista.Insert(1, 2);

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.ReadKey();
        }
    }
}
