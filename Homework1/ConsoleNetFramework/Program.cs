using System;
using ToUpperHtmlTagsLibraryNetFramework;

namespace ConsoleNetFramework
{
    class Program
    {
        static void Main()
        {
            var inputHtml = @"<html><head><TITLE>To jest tytul</Title></head><body><b>Cos tam</b></body></html>";
            var outputHtml = ToUpperHtmlTagsHelperNetFramework.ToUpperHtmlTags(inputHtml);

            Console.WriteLine("Input:\n");
            Console.WriteLine(inputHtml);
            Console.WriteLine("\nOutput:\n");
            Console.WriteLine(outputHtml);
            Console.ReadKey();

        }
    }
}
