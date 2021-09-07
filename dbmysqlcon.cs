using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    class dbmysqlcon
    {
        MySqlConnection connection = new MySqlConnection("server=sql5.freesqldatabase.com;port=3306;username=sql5434752;password=yFlILGKVwt;database=sql5434752");
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }

}
