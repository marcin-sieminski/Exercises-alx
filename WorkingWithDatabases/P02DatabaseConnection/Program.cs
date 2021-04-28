using System;

namespace P02DatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbConnection = new DatabaseConnection();
            var data = dbConnection.ExecuteSqlCommand("select * from zawodnicy");
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data[i].Length; j++)
                {
                    Console.WriteLine(data[i][j] + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
