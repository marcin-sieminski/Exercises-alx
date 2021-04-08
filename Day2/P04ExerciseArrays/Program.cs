using System;

namespace P04ExerciseArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz działanie:");
            var działanie = Console.ReadLine();
            string[] strings = działanie.Split('+', '-', '*', '/');

            double firstNumber = double.Parse(strings[0].Trim());
            var secondNumber = double.Parse(strings[1].Trim());
            double? solution;
            string opDziałania;

            if (działanie.Contains("+"))
            {
                solution = firstNumber + secondNumber;
                opDziałania = "+";
            }
            else if (działanie.Contains("-"))
            {
                solution = firstNumber - secondNumber;
                opDziałania = "-";
            }
            else if (działanie.Contains("*"))
            {
                solution = firstNumber * secondNumber;
                opDziałania = "*";
            }
            else if (działanie.Contains("/"))
            {
                solution = firstNumber / secondNumber;
                opDziałania = "/";
            }
            else
            {
                solution = null;
                opDziałania = null;
            }


            if (solution != null)
            {
                Console.WriteLine($"Wynik działania: {firstNumber} {opDziałania} {secondNumber} = {solution}");
            }

            Console.ReadLine();
        }
    }
}
