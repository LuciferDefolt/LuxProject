using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TestProjectLuxoft
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()// підключення до БД
        {
            string host = "localhost";
            int port = 3306;
            string database = "TestProjectLuxoft";
            string username = "root";
            string password = "root";
            return DBMySQLUtils.GetMySqlConnection(host, port, database, username, password);
        }
    }
}
