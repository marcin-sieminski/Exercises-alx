using System;

namespace P03Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "ala ma kota";
            var sLength = s.Length;
            Console.WriteLine(sLength);
            var w1 = s.Substring(4, 2);
            s = s.Replace("ma", "będzie miała");
            Console.WriteLine(s);
            var contains = s.Contains("ala");
            s = s.ToLower();
            s = s.ToUpper();
            var s2 = s + " i psa";
            string s3 = s2.Substring(0, 3);
            var b1 = s3 == "ala".ToUpper();
            Console.WriteLine(b1);
            Console.ReadKey();

        }
    }
}
