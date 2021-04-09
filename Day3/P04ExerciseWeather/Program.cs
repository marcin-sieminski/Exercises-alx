using System;

namespace P04ExerciseWeather
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

                var weather = new WeatherManager();
                weather.CityName = city;
                Console.WriteLine($"{weather.GetWeather()} in {weather.CityName}");
            }
        }
    }
}
