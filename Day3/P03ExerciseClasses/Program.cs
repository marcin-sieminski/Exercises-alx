using System;

namespace P03ExerciseClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var temperatureConverter = new TemperatureConverter();
            
            Console.WriteLine($"25 st.C = {temperatureConverter.CelsiusToFahrenheit(25d)} st.F");
            Console.ReadKey();
        }
    }
}
