using System.Collections.Generic;
using System.Data.SqlClient;

namespace P02DatabaseConnection
{
    public class DatabaseConnection
    {
        private string _connectionString;

        public DatabaseConnection(string address = "mssql4.webio.pl,2401", string databaseName = "tomasz1_zawodnicy", string userName = "tomasz1_alxalx", string password = "Alxalx!1")
        {
            _connectionString = "Data Source=" + address + ";Initial Catalog=" + databaseName + ";User ID=" + userName +
                               ";Password=" + password;
        }

        public DatabaseConnection()
        {
            _connectionString =
                "Data Source=mssql4.webio.pl,2401;Initial Catalog=tomasz1_zawodnicy;User ID=tomasz1_alxalx;Password=Alxalx!1";
        }

        public object[][] ExecuteSqlCommand(string sql)
        {

            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
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
