using System;
using System.Net;

namespace P11ExerciseWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a city name (exit = exit):");
                var city = Console.ReadLine()?.ToLower();
                if (city == "exit" || city is null)
                {
                    break;
                }

                string address = "http://google.pl/search?q=pogoda " + city;

                string data = new WebClient().DownloadString(address);

                var index = data.IndexOf("°");
                var backwardIndex = index - 1;
                while (data.Substring(backwardIndex, 1) != ">")
                {
                    backwardIndex--;
                }

                var weatherInfo = data.Substring(backwardIndex + 1, index - backwardIndex + 1);

                Console.WriteLine($"Current weather: {weatherInfo}");
            }
        }
    }
}
