using System.Net;

namespace P07Weather
{
    public class WeatherManager
    {
        public string CityName { get; set; }
        private const string url = "http://google.pl/search?q=pogoda ";

        public WeatherManager()
        {
            
        }

        public double GetWeather()
        {
            string data = new WebClient().DownloadString(url + CityName);

            var index = data.IndexOf("°");
            var backwardIndex = index - 1;
            while (data.Substring(backwardIndex, 1) != ">")
            {
                backwardIndex--;
            }

            var weatherString = data.Substring(backwardIndex + 1, index - backwardIndex - 1);
            var weatherValue = double.Parse(weatherString);

            return weatherValue;
        }
    }
}
