using System;
using System.Data.SqlClient;

namespace P01Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection; //komunikacja z bd
            SqlCommand command; // przechowuje polecenia sql
            SqlDataReader dataReader; // czytanie danych z bd

            string connectionString =
                "Data Source=mssql4.webio.pl,2401;Initial Catalog=tomasz1_zawodnicy;User ID=tomasz1_alxalx;Password=Alxalx!1";

            connection = new SqlConnection(connectionString);

            command = new SqlCommand("SELECT * FROM zawodnicy", connection);
            connection.Open();

            dataReader = command.ExecuteReader(); // wysłanie polecenia do bd
            
            dataReader.Read(); //odczytanie rekordu z bd

            string wynik = Convert.ToString(dataReader.GetValue(3)); // odczytanie wartości z i-tej kolumny odczytanego rekordy

            while (dataReader.Read())
            {
                Console.WriteLine(dataReader.GetValue(2) + " " + dataReader.GetValue(3));
            }

            connection.Close();

            Console.ReadKey();
        }
    }
}
