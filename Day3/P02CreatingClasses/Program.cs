using System;

namespace P02CreatingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Calculator c = new Calculator();
            Person p1 = new Person();
            Person p2 = new Person();

            p1.Name = "Joe";
            p1.Age = 18;

            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Age);
            Console.WriteLine(p2.Name);
            Console.WriteLine(p2.Age);

            p1.Scream();

            Console.ReadKey();
        }
    }
}
