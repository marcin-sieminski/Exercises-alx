using System.IO;
using System.Net;

namespace P10WebClientWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            string address = "http://google.pl/search?q=pogoda warszawa";

            string data = new WebClient().DownloadString(address);


            File.WriteAllText(@"c:\tools\data\weather.html", data);
        }
    }
}
