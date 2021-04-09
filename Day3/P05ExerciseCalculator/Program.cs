using System;

namespace P05ExerciseCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var continueCalculations = true;
            while (continueCalculations)
            {
                Console.WriteLine("Enter first number:");
                var firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                var secondNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Choose an operation: 1. adding, 2. subtracting");
                OperationType operation = Convert.ToInt32(Console.ReadLine()) == 1
                    ? OperationType.Add
                    : OperationType.Subtract;

                var calculator = new UniversalCalculator();
                calculator.OperationType = operation;
                var result = calculator.Calculate(firstNumber, secondNumber);

                Console.WriteLine($"Result: {result}");
                Console.WriteLine("Continue? (y/n)");
                if (Console.ReadLine() != "y")
                {
                    continueCalculations = false;
                }
            }
        }
    }
}
