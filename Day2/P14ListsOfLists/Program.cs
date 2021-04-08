using System;
using System.Collections.Generic;

namespace P14ListsOfLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listStrings = new List<string>();
            List<List<string>> listListStrings = new List<List<string>>();
            List<List<List<List<string>>>> listListListListStrings = new List<List<List<List<string>>>>();

            listListStrings.Add(new List<string>());
            listListStrings[0].Add("01");
            listListStrings[0].Add("02");
            listListStrings[0].Add("03");

            listListStrings.Add(new List<string>());
            listListStrings[1].Add("04");
            listListStrings[1].Add("05");

            foreach (var list in listListStrings)
            {
                foreach (var elementOnList in list)
                {
                    Console.WriteLine(elementOnList + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
