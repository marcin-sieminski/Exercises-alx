using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace P04DataBinding
{
    class PlayerHelper
    {
        public List<Player> Players { get; set; } = new ();
        public string LocalPath { get; set; } = @"c:\tools\data\zawodnicy.txt";
        public string WebAddress { get; set; }= "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
        public DataSource DataSource { get; set; }
        public string[] Data { get; set; }
        public List<string> InvalidData { get; set; } = new();

        public PlayerHelper(DataSource source)
        {
            DataSource = source;
        }

        public void LoadData()
        {
            switch (DataSource)
            {
                case DataSource.LocalFile:
                    LoadDataFromFile();
                    break;
                case DataSource.Web:
                    LoadDataFromWeb();
                    break;
            }

            ParseDataToList();
        }

        private void LoadDataFromWeb()
        {
            string data = new WebClient().DownloadString(WebAddress);
            Data = data.Split(new string[]{"\r\n"}, StringSplitOptions.RemoveEmptyEntries);
        }

        private void LoadDataFromFile()
        {
            Data = File.ReadAllLines(LocalPath);
        }

        private void ParseDataToList()
        {
            for (var i = 1; i < Data.Length; i++)
            {
                var splitRow = Data[i].Split(';');
                try
                {
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
                catch (Exception)
                {
                    InvalidData.Add(Data[i]);
                }
            }
        }

        public List<Player> GetPlayersByCountry(string country)
        {
            var playersByCountry = new List<Player>();
            foreach (var player in Players)
            {
                if (player.Country.ToLower() == country.ToLower())
                {
                    playersByCountry.Add(player);
                }
            }
            return playersByCountry;
        }

        public double GetAverageHeight()
        {
            return GetAverageHeight(Players.ToArray());
        }

        private double GetAverageHeight(Player[] players)
        {
            var heightSum = 0d;
            foreach (var player in players)
            {
                heightSum += player.Height;
            }

            return heightSum / players.Length;
        }

        private string[] GetCountries()
        {
            var countries = new List<string>();
            foreach (var player in Players)
            {
                if (!countries.Contains(player.Country))
                {
                    countries.Add(player.Country);
                }
            }

            return countries.ToArray();
        }

        public double GetAverageWeight()
        {
            var weightSum = 0d;
            foreach (var player in Players)
            {
                weightSum += player.Weight;
            }

            return weightSum / Players.Count;
        }

        public GroupCountry[] GetAverageHeightInCountry()
        {
            var countries = GetCountries();
            var gc = new List<GroupCountry>();
            foreach (var country in countries)
            {
                var playersFromCountry = GetPlayersByCountry(country).ToArray();
                var averageHeight = GetAverageHeight(playersFromCountry);
                GroupCountry g = new GroupCountry {CountryName = country, AverageValue = averageHeight};
                gc.Add(g);
            }

            return gc.ToArray();
        }
    }
}
