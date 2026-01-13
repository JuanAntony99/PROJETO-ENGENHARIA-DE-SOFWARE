using BarberShop.Models;
using BarberUp.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using BarberShop.Conexao;

namespace BarberShop.DAL
{
    public class DAL_Funcionarios : IFuncionarios
    {
        string name = "Funcionário";

        private MySqlConnection _conexao;
        MySqlCommand comando = new MySqlCommand();
        public DAL_Funcionarios()
        {
            this._conexao = new Connection_Factory().getConection();
        }

        public void AtualizarFuncionario(Funcionarios f)
        {
            throw new NotImplementedException();
        }

        public void DeletarFuncionario(int Id)
        {
            try 
            { 
                _conexao.Open();

                string sql = "DELETE FROM tb_funcionarios WHERE Id=@id";
                MySqlCommand comando = new MySqlCommand(sql, _conexao);

                comando.CommandText = sql;
                comando.Connection = _conexao;

                comando.Parameters.AddWithValue("Id", Id);

                comando.Prepare();
                int linhas = comando.ExecuteNonQuery();

                if (linhas == 1)
                {
                    MessageBox.Show($"{name} excluído com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (linhas == 0)
                {
                    MessageBox.Show("O Id informado não existe.", $"Erro ao excluir {name}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $"Erro ao excluir {name}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conexao.State == ConnectionState.Open)
                {
                    _conexao.Close();
                }
            }
        }

        public void InserirFuncionario(Funcionarios f)
        {
            try
            { 
                _conexao.Open();

                string sql = "INSERT INTO tb_funcionarios (Nome, Telefone, Comissao, Ativo) VALUES (@nome, @telefone, @Comissao, @Ativo)";
                comando = new MySqlCommand(sql, _conexao);

                comando.CommandText = sql;
                comando.Connection = _conexao;

                comando.Parameters.AddWithValue("@nome", f.Nome);
                comando.Parameters.AddWithValue("@telefone", f.Telefone);
                comando.Parameters.AddWithValue("comissao", f.Comissao);
                comando.Parameters.AddWithValue("@ativo", f.Ativo);

                comando.Prepare();
                comando.ExecuteNonQuery();

                MessageBox.Show($"{name} inserido com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, $"Erro ao inserir {name}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conexao.State == ConnectionState.Open)
                {
                    _conexao.Close();
                }
            }
        }

        public DataTable VerificarFuncionario()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM tb_funcionarios";

                MySqlCommand comando = new MySqlCommand(sql, _conexao);

                _conexao.Open();
                comando.ExecuteNonQuery();

                MySqlDataAdapter sql_relacao = new MySqlDataAdapter(comando);
                sql_relacao.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public DataTable VerificarFuncionario_porId(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
