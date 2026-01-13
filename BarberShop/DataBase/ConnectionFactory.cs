using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace BarberShop.DataBase
{
    public class ConnectionFactory
    {
        public MySqlConnection getConection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["conexao_dbprojetoengenhariadesoftware"].ConnectionString;
            return new MySqlConnection(conexao);
        }

    }
}
