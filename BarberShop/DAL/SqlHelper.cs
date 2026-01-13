using BarberShop.Conexao;
using BarberShop.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using BarberShop.Interfaces;

namespace BarberShop.DAL
{
    internal class SqlHelper:ISqlHelper
    {
        // variavel para o nome nas mensagebox
        string name = "Cliente";

        // variavel com o nome da tabela no banco de dados
        string table_name = "TB_CLIENTES";

        // variavel para sql da fucao update
        string sql_update = "nome=@nome,email=@email,telefone=@telefone,ativo=@ativo,data_cadastro=@data_cadastro";

        // variavel para sql da funcao insert
        string sql_insert = "(nome,email,telefone,ativo,data_cadastro) VALUES (@nome,@email,@telefone,@ativo,@data_cadastro)";

        private MySqlConnection _conexao;
        MySqlCommand comando = new MySqlCommand();
        public SqlHelper(string Name, string Table_Name, string Sql_Update, string Sql_Insert)
        {
            this._conexao = new Connection_Factory().getConection();
            name = Name;
            table_name = Table_Name;
            sql_update = Sql_Update;
            sql_insert = Sql_Insert;
        }
        private void AddParametersFromObject(MySqlCommand command, object data)
        {
            foreach (var prop in data.GetType().GetProperties())
            {
                // Pega o nome da propriedade e o valor
                string paramName = "@" + prop.Name;
                object value = prop.GetValue(data) ?? DBNull.Value;

                command.Parameters.AddWithValue(paramName, value);
            }
        }
        public bool Deletar(int codigo_cliente)
        {

            try
            {
                _conexao.Open();

                string _sql = $"DELETE FROM {table_name} WHERE ID=@ID";
                MySqlCommand comando = new MySqlCommand(_sql, _conexao);

                comando.CommandText = _sql;
                comando.Connection = _conexao;

                comando.Parameters.AddWithValue("ID", codigo_cliente);

                comando.Prepare();
                int linhas = comando.ExecuteNonQuery();

                if (linhas == 1)
                {
                    MessageBox.Show($"{name} excluido com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }

                if (linhas == 0)
                {
                    MessageBox.Show("O ID informado não existe.", $"Erro ao excluir {name}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    MessageBox.Show("Erro desconhecido ao excluir.", $"Erro ao excluir {name}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message, $"Erro ao excluir {name}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (_conexao.State == ConnectionState.Open)
                {
                    _conexao.Close();
                }
            }
        }

        public void Editar(object obj)
        {
            try
            {
                _conexao.Open();

                string _sql = $"UPDATE {table_name} SET {sql_update} WHERE id=@id";
                comando = new MySqlCommand(_sql, _conexao);

                comando.CommandText = _sql;
                comando.Connection = _conexao;

                AddParametersFromObject(comando, obj);

                comando.Prepare();
                comando.ExecuteNonQuery();

                MessageBox.Show($"{name} editado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message, $"Erro ao editar {name}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conexao.State == ConnectionState.Open)
                {
                    _conexao.Close();
                }
            }
        }

        public void Inserir(object obj)
        {
            try
            {
                _conexao.Open();


                string _sql = $"INSERT INTO {table_name} {sql_insert}";
                comando = new MySqlCommand(_sql, _conexao);

                comando.CommandText = _sql;
                comando.Connection = _conexao;

                AddParametersFromObject(comando, obj);


                comando.Prepare();
                comando.ExecuteNonQuery();

                MessageBox.Show($"{name} inserido com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message, $"Erro ao inserir {name}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conexao.State == ConnectionState.Open)
                {
                    _conexao.Close();
                }
            }
        }

        public DataTable Selecionar()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = $@"SELECT * FROM {table_name}";

                MySqlCommand comandosql = new MySqlCommand(sql, _conexao);

                _conexao.Open();
                comandosql.ExecuteNonQuery();

                MySqlDataAdapter sql_relacao = new MySqlDataAdapter(comandosql);
                sql_relacao.Fill(dt);

                return dt;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                if (_conexao.State == ConnectionState.Open)
                {
                    _conexao.Close();
                }
            }
        }

        public DataTable Selecionar_porID(int id)
        {


            DataTable dt = new DataTable();

            string sql = $"SELECT * FROM {table_name} WHERE id = @id";

            using (MySqlCommand comandoSql = new MySqlCommand(sql, _conexao))
            {

                comandoSql.Parameters.Add("@id", MySqlDbType.Int32).Value = id;


                MySqlDataAdapter sql_relacao = new MySqlDataAdapter(comandoSql);

                try
                {

                    _conexao.Open();

                    sql_relacao.Fill(dt);

                    return dt;
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                finally
                {

                    if (_conexao != null && _conexao.State == ConnectionState.Open)
                    {
                        _conexao.Close();
                    }
                }
            }
        }
    }
}
