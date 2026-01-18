using BarberShop.Conexao;
using BarberShop.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Xml.Linq;

namespace BarberShop.LoginFuncionario
{

    public class FuncionarioRepository
    {
        private MySqlConnection _conexao;

        public Funcionarios GetByLogin(string login)
        {
            try
            {
                this._conexao = new Connection_Factory().getConection();
                _conexao.Open();

                var cmd = _conexao.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_funcionarios WHERE login = @login AND ativo = 1";

                cmd.Parameters.AddWithValue("@login", login);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Funcionarios
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("nome"),
                        Telefone = reader.GetString("telefone"),
                        Comissao = reader.GetDouble("comissao"),
                        Login = reader.GetString("login"),
                        PasswordHash = reader.GetString("password_hash"),
                        Ativo = reader.GetBoolean("ativo")
                    };
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, $"Erro no login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conexao.State == ConnectionState.Open)
                {
                    _conexao.Close();
                }
            }
            return null;
        }
    }
}
