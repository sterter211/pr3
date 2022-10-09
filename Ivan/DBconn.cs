using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Ivan
{
    class DBconn
    {
        public static MySqlConnection GetDBConnection(string host, int port, string database, string user, string pass)
        {
            String connstring = "Server=" + host + ";database=" + database + ";port=" + port.ToString() + ";user=" + user + ";password=" + pass + ";";
            MySqlConnection conn = new MySqlConnection(connstring);
            return conn;
        }



    }
}
