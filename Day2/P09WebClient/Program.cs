using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P09WebClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string address = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";

            string data = new WebClient().DownloadString(address);
            string[] entries = data.Split(new string[]{"\r\n"}, StringSplitOptions.RemoveEmptyEntries);

            string addressWp = "http://wp.pl";
            string dataWp = new WebClient().DownloadString(addressWp);
            File.WriteAllText(@"c:\tools\data\wp.html", dataWp);
        }
    }
}
