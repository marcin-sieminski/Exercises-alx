using System;

namespace P13JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] jaggedStrings = new string[4][];

            jaggedStrings[0] = new string[1];
            jaggedStrings[1] = new string[2];
            jaggedStrings[2] = new string[5];
            jaggedStrings[3] = new string[3];

            jaggedStrings[0][0] = "01";
            
            jaggedStrings[1][0] = "02";
            jaggedStrings[1][1] = "03";

            jaggedStrings[2][0] = "04";
            jaggedStrings[2][1] = "05";
            jaggedStrings[2][2] = "06";
            jaggedStrings[2][3] = "07";
            jaggedStrings[2][4] = "08";

            jaggedStrings[3][0] = "09";
            jaggedStrings[3][1] = "10";
            jaggedStrings[3][2] = "11";

            for (int i = 0; i < jaggedStrings.Length; i++)
            {
                for (int j = 0; j < jaggedStrings[i].Length; j++)
                {
                    Console.WriteLine(jaggedStrings[i][j] + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
