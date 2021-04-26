using System;

namespace P05References
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            a++;
            Console.WriteLine(a);
            Console.WriteLine(b);

            Person person1 = new Person();
            person1.Age = 1;

            Person person2 = person1;
            person1.Age++;
            Console.WriteLine(person1.Age);
            Console.WriteLine(person2.Age);

            Console.ReadKey();
        }
    }
}
