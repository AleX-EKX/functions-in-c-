using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace avtorization
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3307; username=root; password=root; database=avtorization");
        public void conectionOpen()
        {
            if (connection.State == System.Data.ConnectionState.Closed)//если состояние бд закрыто, то делаем
                connection.Open();
        }

        public void connectionClosed()
        {
            if (connection.State == System.Data.ConnectionState.Open)//если состояние бд открыто, то делаем
                connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }



    }


   
}
