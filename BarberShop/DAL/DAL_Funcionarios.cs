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

        public bool DeletarFuncionario(int Id)
        {
            throw new NotImplementedException();
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
            }
        }

        public DataTable VerificarFuncionario(int Id)
        {
            throw new NotImplementedException();
        }

        public DataTable VerificarFuncionario_porId(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
