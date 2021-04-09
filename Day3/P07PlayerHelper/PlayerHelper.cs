using System;
using System.Collections.Generic;
using System.IO;

namespace P07PlayerHelper
{
    class PlayerHelper
    {
        public List<Player> Players { get; set; } = new ();

        public void Load()
        {
            var path = @"c:\tools\data\zawodnicy.txt";
            var data = File.ReadAllLines(path);

            for (var i =1; i < data.Length; i++)
            {
                var splitRow = data[i].Split(';');
                Players.Add(new Player
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
        }
    }
}
