using System;
using System.Net;

namespace P15ExerciseArraysLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
            string data = new WebClient().DownloadString(url);
            string[] rows = data.Split(new string[] {"\r\n"}, StringSplitOptions.RemoveEmptyEntries);

            int numberOfColumns = rows[0].Split(';').Length;
            int numberOfRows = rows.Length - 1;

            string[,] arrStrings = new string[numberOfRows, numberOfColumns];

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    string[] tmp = rows[i + 1].Split(';');
                    arrStrings[i, j] = tmp[j];
                }
            }

            string[][] arrayStrings = new string[numberOfRows][];
            for (int i = 0; i < numberOfRows; i++)
            {
                arrayStrings[i] = rows[i + 1].Split(';');
            }

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    Console.WriteLine(arrStrings[i,j] + " ");
                }
            }

            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < numberOfRows; i++)
            {
                Console.WriteLine(string.Join(" ", arrayStrings[i]));
            }

            Console.ReadKey();

        }
    }
}
