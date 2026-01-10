using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using MySql.Data.MySqlClient;


namespace BarberShop.Conexao
{
    internal class Connection_Factory
    {
        public MySqlConnection getConection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["conexao_dbprojetoengenhariadesoftware"].ConnectionString;
            return new MySqlConnection(conexao);
        }
    }
}
