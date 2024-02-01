using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HotelAlexa
{
    internal class Connection
    {
        public static MySqlConnection conn = null;
       public void Connection_Now()
        {
            conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=hotelalexa");
            conn.Open();
        }
    }
}
