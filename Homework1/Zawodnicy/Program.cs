using System;

namespace Zawodnicy
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerDanych md = new ManagerDanych();
            md.ImportujWszystko();

            Console.ReadKey();
        }
    }
}
