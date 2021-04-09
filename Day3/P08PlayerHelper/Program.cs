using System;

namespace P08PlayerHelper
{
    class Program
    {
        static void Main()
        {
            var playerHelper = new PlayerHelper(DataSource.LocalFile);
            playerHelper.LoadData();
            var poles = playerHelper.GetPlayersByCountry("pol");
            foreach (var pole in poles)
            {
                Console.WriteLine(pole.GetInfo());
            }

            var averageHeightInCountries = playerHelper.GetAverageHeightInCountry();
            foreach (var averageHeightInCountry in averageHeightInCountries)
            {
                Console.WriteLine($"{averageHeightInCountry.CountryName} {averageHeightInCountry.AverageValue:F1}");
            }
            Console.ReadLine();
        }
    }
}
