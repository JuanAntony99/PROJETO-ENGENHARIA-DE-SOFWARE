using BarberShop.Conexao;
using BarberShop.Interfaces;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text;

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

        public DataTable Selecionar_porCampo(string campo, string valorBusca, string dadosTable)
        {
            DataTable dt = new DataTable();
            string sql = $"SELECT {dadosTable} FROM {table_name} WHERE {campo} LIKE @valor ORDER BY {campo} LIMIT 50";

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

        public DataTable Selecionar_porDataTime(string campo, DateTime dataInicio, DateTime dataFim)
        {
            DataTable dt = new DataTable();
            string sql = $"SELECT * FROM {table_name} WHERE {campo} >= @dataInicio AND {campo} <= @dataFim ORDER BY {campo} LIMIT 100";

            using (MySqlCommand comandoSql = new MySqlCommand(sql, _conexao))
            {

                comandoSql.Parameters.AddWithValue("@dataInicio", dataInicio);
                comandoSql.Parameters.AddWithValue("@dataFim", dataFim);
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

        public DataTable Selecionar_Join(string[] tabelasJoin, string[] colunasLigacao, DateTime? inicio = null, DateTime? fim = null)
        {
            DataTable dt = new DataTable();
            StringBuilder sql = new StringBuilder();

            // Inicia o SELECT usando o alias 'a' para a table_name da classe
            sql.Append($"SELECT a.id AS 'ID', ");

            // Adiciona as colunas de NOME das tabelas relacionadas
            for (int i = 0; i < tabelasJoin.Length; i++)
            {
                // Pega a primeira letra após "tb_" para criar o alias (ex: 'c' para tb_clientes)
                string aliasRelacional = tabelasJoin[i].Substring(3, 1);
                sql.Append($"{aliasRelacional}.nome AS '{tabelasJoin[i].Replace("tb_", "")}', ");
            }

            sql.Append("a.datahora_agendamento AS 'Data/Hora' ");

            // USA A VARIÁVEL DA CLASSE table_name
            sql.Append($"FROM {table_name} a ");

            // Monta os INNER JOINs
            for (int i = 0; i < tabelasJoin.Length; i++)
            {
                string aliasRelacional = tabelasJoin[i].Substring(3, 1);
                sql.Append($"INNER JOIN {tabelasJoin[i]} {aliasRelacional} ON a.{colunasLigacao[i]} = {aliasRelacional}.id ");
            }

            // Filtro de data opcional
            if (inicio.HasValue && fim.HasValue)
            {
                sql.Append(" WHERE a.datahora_agendamento BETWEEN @inicio AND @fim ");
            }

            sql.Append(" ORDER BY a.datahora_agendamento ASC LIMIT 100");

            using (MySqlCommand cmd = new MySqlCommand(sql.ToString(), _conexao))
            {
                if (inicio.HasValue && fim.HasValue)
                {
                    cmd.Parameters.AddWithValue("@inicio", inicio.Value);
                    cmd.Parameters.AddWithValue("@fim", fim.Value);
                }

                try
                {
                    _conexao.Open();
                    new MySqlDataAdapter(cmd).Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na busca: " + ex.Message);
                    return null;
                }
                finally { _conexao.Close(); }
            }
        }
    }
}