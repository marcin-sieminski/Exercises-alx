using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;

namespace P04PlayersManager.Tools
{
    public class DatabaseConnection
    {
        private readonly string _connectionString;

        public DatabaseConnection()
        {
            _connectionString =
                File.ReadAllText("..\\..\\..\\..\\alx_example\\connectionstring.txt");
        }

        public object[][] ExecuteSqlCommand(string sql)
        {
            SqlConnection connection; 
            SqlCommand command; 
            SqlDataReader dataReader;

            connection = new SqlConnection(_connectionString);
            command = new SqlCommand(sql, connection);

            connection.Open();
            dataReader = command.ExecuteReader();

            List<object[]> rowsList = new List<object[]>();

            while (dataReader.Read())
            {
                object[] cells = new object[dataReader.FieldCount];
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    cells[i] = dataReader.GetValue(i);
                }
                rowsList.Add(cells);
            }
            connection.Close();
            return rowsList.ToArray();
        }
    }
}
