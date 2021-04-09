using System;

namespace P07PlayerHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerHelper = new PlayerHelper();
            playerHelper.Load();

            foreach (var player in playerHelper.Players)
            {
                Console.WriteLine(player.GetInfo());
            }

            Console.ReadLine();
        }
    }
}
