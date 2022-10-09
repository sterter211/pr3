using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ivan
{
    class DBUntils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "test";
            string user = "root";
            string pass = "123456789";


            return DBconn.GetDBConnection(host, port, database, user, pass);
        }



    }
}
