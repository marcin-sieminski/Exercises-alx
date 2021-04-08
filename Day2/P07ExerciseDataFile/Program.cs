using System;
using System.Collections.Generic;
using System.IO;

namespace P07ExerciseDataFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = File.ReadAllLines(@"c:\tools\data\zawodnicy.txt");
            Console.WriteLine("Enter country code:");
            var countryCode = Console.ReadLine().ToLower();
            var players = new List<string>();

            for (int i = 1; i < data.Length; i++)
            {
                var dataEntry = data[i].Split(';');
                if (dataEntry[4].ToLower().Equals(countryCode))
                {
                    var playerFirstName = $"{dataEntry[2].Substring(0, 1).ToUpper()}{dataEntry[2].Substring(1).ToLower()}";
                    var playerLastName = $"{dataEntry[3].Substring(0, 1).ToUpper()}{dataEntry[3].Substring(1).ToLower()}";
                    players.Add($"{playerFirstName} {playerLastName}");
                }
            }

            if (players.Count > 0)
            {
                var filePath = Path.Combine(@"c:\", "tools", "data", countryCode.ToLower() + ".txt");
                File.WriteAllLines(filePath, players);
            }
        }
    }
}
