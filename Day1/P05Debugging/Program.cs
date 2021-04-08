using System;

namespace P05Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            string napis = "hej";
            int a = 10;
            int b = 5;
            b = b * 2;
            b -= 10;
            int c = a / b;

            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
