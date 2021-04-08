using System.IO;

namespace P05FileOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "ala \nma \nkota";
            File.WriteAllText(@"c:\tools\data\text.txt", text);
            var readAllText = File.ReadAllText(@"c:\tools\data\text.txt");
            var textArray = readAllText.Split('\n');

            var readAllLines = File.ReadAllLines(@"c:\tools\data\text.txt");
            readAllLines[1] = "xxx";
            File.WriteAllLines(@"c:\tools\data\text.txt", readAllLines);
        }
    }
}
