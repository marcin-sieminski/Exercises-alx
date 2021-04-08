using System;
using System.Collections.Generic;

namespace P02ListsAndArraysOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string napis = "ala ma kota";
            string[] stringsArray = napis.Split(' ');
            for (int i = 0; i < stringsArray.Length; i++)
            {
                Console.WriteLine(stringsArray[i]);
            }

            string[] tablica = new string[3];

            tablica[0] = "Jan";
            tablica[1] = "Ala";
            tablica[2] = "Adam";

            string napis2 = string.Join(" ", tablica);
            Console.WriteLine(napis2);

            List<string> lista = new List<string>();
            lista.Add("jeden");
            lista.Add("dwa");
            lista.Add("trzy");

            string napis3 = string.Join(" ", lista.ToArray());
            Console.WriteLine(napis3);

            Console.ReadKey();
        }
    }
}
