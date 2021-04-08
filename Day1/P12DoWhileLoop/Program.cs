using System;

namespace P12DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string zdanie = "";
            int pozycja = 0;

            do
            {
                Console.WriteLine(zdanie.Substring(pozycja, 1));
                pozycja++;
            } while (pozycja < zdanie.Length);
        }
    }
}
