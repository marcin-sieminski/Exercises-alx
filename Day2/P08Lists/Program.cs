using System.Collections.Generic;

namespace P08ListsArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[2];
            array[0] = "first entry";

            List<string> list = new List<string>();
            list.Add("first entry");
            list[0] = "new entry";
        }
    }
}
