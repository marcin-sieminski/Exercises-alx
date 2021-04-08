using System;

namespace P09SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            var liczba = 1;
            switch (liczba)
            {
                case 1:
                    Console.WriteLine("jeden");
                    break;
                default:
                    Console.WriteLine("nic");
                break;
            }
        }
    }
}
