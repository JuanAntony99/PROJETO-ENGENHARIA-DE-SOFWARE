using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarberShop.Conexao;
using BarberShop.Interfaces;
using MySql.Data.MySqlClient;
using BarberShop.Models;

namespace BarberShop.DAL
{
    internal class DAL_Clientes : IClientes
    {
        // variavel para o nome nas mensagebox
        string name = "Cliente";

        private MySqlConnection _conexao;
        MySqlCommand comando = new MySqlCommand();
        public DAL_Clientes()
        {
            this._conexao = new Connection_Factory().getConection();
        }

        public void Deletar_Clientes(int codigo_cliente)
        {

            try
            {
                _conexao.Open();

                string _sql = "DELETE FROM TB_CLIENTES WHERE ID=@ID";
                MySqlCommand comando = new MySqlCommand(_sql, _conexao);

                comando.CommandText = _sql;
                comando.Connection = _conexao;

                comando.Parameters.AddWithValue("ID", codigo_cliente);

                comando.Prepare();
                int linhas = comando.ExecuteNonQuery();

                if (linhas == 1)
                {
                    MessageBox.Show($"{name} excluido com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (linhas == 0)
                {
                    MessageBox.Show("O ID informado não existe.", $"Erro ao excluir {name}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message, $"Erro ao excluir {name}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conexao.State == ConnectionState.Open)
                {
                    _conexao.Close();
                }
            }
        }

        public void Editar_Clientes(Clientes clientes)
        {
            try
            {
                _conexao.Open();

                string _sql = "UPDATE TB_CLIENTES SET nome=@nome,email=@email,telefone=@telefone,ativo=@ativo,data_cadastro=@data_cadastro WHERE id=@id";
                comando = new MySqlCommand(_sql, _conexao);

                comando.CommandText = _sql;
                comando.Connection = _conexao;

                comando.Parameters.AddWithValue("id", clientes.id);
                comando.Parameters.AddWithValue("nome", clientes.nome);
                comando.Parameters.AddWithValue("email", clientes.email);
                comando.Parameters.AddWithValue("telefone", clientes.telefone);
                comando.Parameters.AddWithValue("ativo", clientes.ativo);
                comando.Parameters.AddWithValue("data_cadastro", clientes.data_cadastro);

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

        public void Inserir_Clientes(Clientes clientes)
        {
            try
            {
                _conexao.Open();


                string _sql = "INSERT INTO TB_CLIENTES (nome,email,telefone,ativo,data_cadastro) VALUES (@nome,@email,@telefone,@ativo,@data_cadastro)";
                comando = new MySqlCommand(_sql, _conexao);

                comando.CommandText = _sql;
                comando.Connection = _conexao;

                comando.Parameters.AddWithValue("@nome", clientes.nome);
                comando.Parameters.AddWithValue("@email", clientes.email);
                comando.Parameters.AddWithValue("@telefone", clientes.telefone);
                comando.Parameters.AddWithValue("@ativo", clientes.ativo);
                comando.Parameters.AddWithValue("data_cadastro", clientes.data_cadastro);


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

        public DataTable Selecionar_Clientes()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"SELECT * FROM TB_CLIENTES";

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

        public DataTable Selecionar_Clientes_porID(int id)
        {


            DataTable dt = new DataTable();

            string sql = "SELECT * FROM tb_clientes WHERE id = @id";

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
