using System;
using System.Collections.Generic;
using System.IO;

namespace P16Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 0;
            string[] array = new string[2];

            try
            {
                array[2] = "a";
                double x = a / b;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Array index exception");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Illegal dividing by zero");
            }
            catch (Exception e)
            {
                Console.WriteLine("Other exception");
            }
            finally
            {
                Console.WriteLine("Always executing part");
            }

            Console.WriteLine("Statements after try-catch");

            string[] rows = File.ReadAllLines(@"c:\tools\data\zawodnicy.txt");
            List<int> invalidRows = new List<int>();
            int sum = 0;

            for (int i = 1; i < rows.Length; i++)
            {
                try
                {
                    sum += Convert.ToInt32(rows[i].Split(';')[6]);
                }
                catch (Exception)
                {
                    invalidRows.Add(i);
                }
            }

            double avg = sum / (rows.Length - 1);
            Console.WriteLine($"Average: {avg} cm");
            Console.WriteLine($"Invalid rows: {string.Join(" ", invalidRows)}");
            Console.ReadKey();
        }
    }
}
