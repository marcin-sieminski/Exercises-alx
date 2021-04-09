using System;
using System.Net;
using System.Text;

namespace P01ValueTypes
{
    class Program
    {
        static void Main()
        {
            int a = 7;
            char b = 'x';
            string c = "napis";
            double d = 5.233;

            DateTime dt = new DateTime(2021, 4, 9);
            WebClient wc = new WebClient();
            StringBuilder sb = new StringBuilder();
            sb.Append("ala");
            sb.Append("ma");
            sb.Append("kota");
        }
    }
}
