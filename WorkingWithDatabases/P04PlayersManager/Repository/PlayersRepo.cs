using P04PlayersManager.Domain;
using P04PlayersManager.Tools;
using System;

namespace P04PlayersManager.Repository
{
    class PlayersRepo
    {
        private DatabaseConnection _dbConnection = new DatabaseConnection();

        private Player[] generatePlayers(object[][] data)
        {
            Player[] players = new Player[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                Player player = new Player();
                player.Id = Convert.ToInt32(data[i][0]);
                if (data[i][1] == DBNull.Value)
                {
                    player.Id_trenera = null;
                }
                else
                {
                    player.Id_trenera = Convert.ToInt32(data[i][1]);
                }
                player.Imie = data[i][2].ToString();
                player.Nazwisko = data[i][3].ToString();
                player.Kraj = data[i][4].ToString();
                player.DataUr = Convert.ToDateTime(data[i][5]);
                player.Wzrost = Convert.ToInt32(data[i][6]);
                player.Waga = Convert.ToInt32(data[i][7]);
                players[i] = player;
            }

            return players;
        }

        public Player[] GetPlayers()
        {
            object[][] data = _dbConnection.ExecuteSqlCommand("select id_zawodnika, id_trenera, imie, nazwisko, kraj, data_ur, wzrost, waga from zawodnicy");
            return generatePlayers(data);
        }

        public Player[] GetPlayers(Filter filter)
        {
            string sql = "select id_zawodnika, id_trenera, imie, nazwisko, kraj, data_ur, wzrost, waga from zawodnicy";
            sql += " where 1=1";

            if (!string.IsNullOrEmpty(filter.Imie))
            {
                sql += $" and imie like '%{filter.Imie}%'";
            }

            if (!string.IsNullOrEmpty(filter.Nazwisko))
            {
                sql += $" and nazwisko like '%{filter.Nazwisko}%'";
            }

            if (!string.IsNullOrEmpty(filter.Kraj))
            {
                sql += $" and kraj like '%{filter.Kraj}%'";
            }

            if (filter.WagaOd != null)
            {
                sql += $" and waga >= {filter.WagaOd}";
            }

            if (filter.WagaDo != null)
            {
                sql += $" and waga <= {filter.WagaDo}";
            }

            if (filter.WzrostOd != null)
            {
                sql += $" and wzrost >= {filter.WzrostOd}";
            }

            if (filter.WzrostDo != null)
            {
                sql += $" and wzrost <= {filter.WzrostDo}";
            }

            if (filter.DataUrOd != null)
            {
                sql += $" and data_ur >= '{filter.DataUrOd}'";
            }

            if (filter.DataUrDo != null)
            {
                sql += $" and data_ur <= '{filter.DataUrDo}'";
            }

            object[][] data = _dbConnection.ExecuteSqlCommand(sql);
            return generatePlayers(data);
        }

        public void AddPlayer(Player player)
        {
            string sql =
                "insert into zawodnicy (id_zawodnika, id_trenera, imie, nazwisko, kraj, data_ur,wzrost,waga)" + 
                string.Format(" values({0}, {1}, '{2}', '{3}', '{4}', '{5}', {6}, {7})", 
                    player.Id, 
                    player.Id_trenera == null ? "null" : Convert.ToString(player.Id_trenera), 
                    player.Imie, 
                    player.Nazwisko, 
                    player.Kraj, 
                    player.DataUr, 
                    player.Wzrost, 
                    player.Waga);

            _dbConnection.ExecuteSqlCommand(sql);
        }

        public void DeletePlayer(int id)
        {
            string sql = $"delete zawodnicy where id_zawodnika = {id}";
            _dbConnection.ExecuteSqlCommand(sql);
        }

        public void EditPlayer(Player player)
        {
            string sql = $@"update zawodnicy set
                            imie = '{player.Imie}',
                            nazwisko = '{player.Nazwisko}',
                            kraj = '{player.Kraj}',
                            data_ur = '{player.DataUr}',
                            wzrost = {player.Wzrost},
                            waga = {player.Waga}
                            where id_zawodnika = {player.Id}";

            _dbConnection.ExecuteSqlCommand(sql);
        }
    }
}
