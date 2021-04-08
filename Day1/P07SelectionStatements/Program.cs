using System;

namespace P07SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wzrost");
            int wzrost = Convert.ToInt32(Console.ReadLine());
            bool c1 = wzrost > 185;
            if (c1)
            {
                Console.WriteLine("jesteś wysoki");
            }
            else Console.WriteLine("jesteś niski");

            string wyn2 = wzrost > 185 ? "jesteś wysoki" : "jesteś niski";


            Console.ReadKey();
        }
    }
}
