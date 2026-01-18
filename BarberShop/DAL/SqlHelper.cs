using BarberShop.Conexao;
using BarberShop.Interfaces;
using MySql.Data.MySqlClient;
using System.Data;

namespace BarberShop.DAL
{
    internal class SqlHelper : ISqlHelper
    {
        // variavel para o nome nas mensagebox
        string name = "";

        // variavel com o nome da tabela no banco de dados
        string table_name = "";

        // variavel para sql da fucao update
        string sql_update = "";

        // variavel para sql da funcao insert
        string sql_insert = "";

        private MySqlConnection _conexao;
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

                using (var comando = new MySqlCommand(_sql, _conexao))
                {
                    comando.Parameters.AddWithValue("@ID", codigo_cliente);
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

        public bool Desativar_Ativar(int id, bool escolha,string campo)
        {
            try
            {
                _conexao.Open();

                string _sql;

                if (escolha)
                {
                    _sql = $"UPDATE {table_name} SET {campo} = 1 WHERE id = @id";
                }
                else
                {
                    _sql = $"UPDATE {table_name} SET {campo} = 0 WHERE id = @id"; ;
                }

                using (var comando = new MySqlCommand(_sql, _conexao))
                {
                    comando.Parameters.AddWithValue($"@{campo}", campo);
                    comando.Parameters.AddWithValue("@id", id);
                    int linhas = comando.ExecuteNonQuery();

                    if (linhas == 0)
                        MessageBox.Show("Registro não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (escolha)
                    {
                        MessageBox.Show($"{name} ativado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"{name} desativado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return true;
                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message, $"Erro ao editar {name}", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                using (var comando = new MySqlCommand(_sql, _conexao))
                {
                    AddParametersFromObject(comando, obj);
                    int linhas = comando.ExecuteNonQuery();

                    if (linhas == 0)
                        MessageBox.Show("Registro não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        MessageBox.Show($"{name} editado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
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

                using (var comando = new MySqlCommand(_sql, _conexao))
                {
                    AddParametersFromObject(comando, obj);
                    int linhas = comando.ExecuteNonQuery();
                    if (linhas == 0)
                        MessageBox.Show("Nenhum registro inserido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show($"{name} inserido com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                string _sql = $@"SELECT * FROM {table_name} LIMIT 100";

                using (var comando = new MySqlCommand(_sql, _conexao))
                {
                    _conexao.Open();
                    MySqlDataAdapter sql_relacao = new MySqlDataAdapter(comando);
                    sql_relacao.Fill(dt);
                }
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

        public DataTable Selecionar_porCampo(string campo, string valorBusca)
        {
            DataTable dt = new DataTable();
            string sql = $"SELECT * FROM {table_name} WHERE {campo} LIKE @valor ORDER BY {campo} LIMIT 100";

            using (MySqlCommand comandoSql = new MySqlCommand(sql, _conexao))
            {

                comandoSql.Parameters.AddWithValue("@valor", valorBusca + "%");
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