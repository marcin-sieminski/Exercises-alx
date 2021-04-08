using System;
using System.IO;

namespace P06ExerciseFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file path:");
            var path = Console.ReadLine();

            Console.WriteLine("Enter a word:");
            var word = Console.ReadLine().ToLower();

            var readAllText = File.ReadAllText(path).ToLower();
            readAllText = readAllText.Replace("\r\n", " ");
            readAllText = readAllText.Replace("\\", " ");

            var textSplit = readAllText.Split();

            var wordOccurrenceCounter = 0;

            foreach (var wordInText in textSplit)
            {
                if (wordInText.Contains(word))
                {
                    wordOccurrenceCounter++;
                }
            }

            Console.WriteLine($"The word: {word} was found {wordOccurrenceCounter}x in the text.");
            Console.ReadLine();
        }
    }
}
