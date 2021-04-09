using System;
using System.Collections.Generic;
using System.IO;

namespace P06ExercisePlayers
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\tools\data\zawodnicy.txt";
            var data = File.ReadAllLines(path);

            var players = new List<Player>();
            
            for (var i =1; i < data.Length; i++)
            {
                var splitRow = data[i].Split(';');
                players.Add(new Player
                {
                    FirstName = splitRow[2],
                    LastName = splitRow[3],
                    Country = splitRow[4],
                    BirthDate = Convert.ToDateTime(splitRow[5]),
                    Height = Convert.ToInt32(splitRow[6]),
                    Weight = Convert.ToInt32(splitRow[7])
                }
                );
            }

            foreach (var player in players)
            {
                Console.WriteLine(player.GetInfo());
            }

            Console.ReadLine();
        }
    }
}
