using System;
using ToUpperHtmlTagsLibrary;

namespace ConsoleNetCore
{
    class Program
    {
        static void Main()
        {
            var inputHtml =
                "<html>\r\n<head>\r\n<TITLE>To jest tytul</Title>\r\n</head>\r\n<body>\r\n<b>Cos tam</b>\r\n</body>\r\n</html>";
            var outputHtml = ToUpperHtmlTagsHelper.ToUpperHtmlTags(inputHtml);

            Console.WriteLine("Input:\n");
            Console.WriteLine(inputHtml);
            Console.WriteLine("\nOutput:\n");
            Console.WriteLine(outputHtml);
            Console.ReadKey();
        }
    }
}
